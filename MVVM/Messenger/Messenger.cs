using System;
using System.Collections.Generic;
using System.Threading;

namespace MVVM.Messenger
{
    //ToDo comment this
    public class Messenger : IMessenger
    {
        private static Messenger _instance;
        private static readonly object LockObject = new object();
        private readonly Dictionary<Type, List<ActionIdentifier>> _references;

        public Messenger()
        {
            _references = new Dictionary<Type, List<ActionIdentifier>>();
        }
        public static Messenger Instance
        {
            get
            {
                lock (LockObject)
                {
                    return _instance ?? (_instance = new Messenger());
                }
            }
        }

        public void Register<TNotification>(object recipient, Action<TNotification> action)
        {
            Register(recipient, null, action);
        }

        public void Register<TNotification>(object recipient, string identCode, Action<TNotification> action)
        {
            var messageType = typeof(TNotification);

            if (!_references.ContainsKey(messageType))
                _references.Add(messageType, new List<ActionIdentifier>());

            var actionIdent = new ActionIdentifier()
            {
                Action = new WeakReferenceAction<TNotification>(recipient, action),
                IdentificationCode = identCode
            };

            _references[messageType].Add(actionIdent);
        }

        public void Send<TNotification>(TNotification notification)
        {
            var type = typeof(TNotification);
            var typeActionIdentifiers = _references[type];

            foreach (ActionIdentifier ai in typeActionIdentifiers)
            {
                if (ai.Action is IActionParameter actionParameter)
                    actionParameter.ExecuteWithParameter(notification);
                else
                    ai.Action.Execute();
            }
        }

        public void Send<TNotification>(TNotification notification, string identCode)
        {
            var type = typeof(TNotification);
            var typeActionIdentifiers = _references[type];
            foreach (ActionIdentifier ai in typeActionIdentifiers)
            {
                if (ai.IdentificationCode == identCode)
                {
                    if (ai.Action is IActionParameter actionParameter)
                        actionParameter.ExecuteWithParameter(notification);
                    else
                        ai.Action.Execute();
                }
            }
        }

        public void Unregister<TNotification>(object recipient)
        {
            var lockTaken = false;
            try
            {
                Monitor.Enter(_references, ref lockTaken);
                foreach (var targetType in _references.Keys)
                {
                    foreach (var wra in _references[targetType])
                    {
                        if (wra.Action != null && wra.Action.Target == recipient)
                            wra.Action.Unload();
                    }
                }
            }
            finally
            {
                if (lockTaken)
                    Monitor.Exit(_references);
            }
        }
    }
}