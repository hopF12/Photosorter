using System;

namespace MVVM.Messenger
{
    //ToDo comment missing
    public class WeakReferenceAction
    {
        private Action _action;

        public WeakReferenceAction(object target, Action action)
        {
            Target = new WeakReference(target);
            _action = action;
        }

        //ToDo comment missing
        public WeakReference Target { get; private set; }

        //ToDo comment missing
        public void Execute()
        {
            if (_action != null && Target != null && Target.IsAlive)
                _action.Invoke();
        }
        //ToDo comment missing
        public void Unload()
        {
            Target = null;
            _action = null;
        }
    }
    //ToDo comment missing
    public class WeakReferenceAction<T> : WeakReferenceAction, IActionParameter
    {
        public WeakReferenceAction(object target, Action<T> action)
            : base(target, null)
        {
            Action = action;
        }
        //ToDo comment missing
        public new void Execute()
        {
            if (Action != null && Target != null && Target.IsAlive)
                Action(default(T));
        }
        //ToDo comment missing
        public void Execute(T parameter)
        {
            if (Action != null && Target != null && Target.IsAlive)
                Action(parameter);
        }
        //ToDo comment missing
        public Action<T> Action { get; }

        #region IActionParameter Members
        //ToDo comment missing
        public void ExecuteWithParameter(object parameter)
        {
            Execute((T)parameter);
        }
        #endregion
    }
}