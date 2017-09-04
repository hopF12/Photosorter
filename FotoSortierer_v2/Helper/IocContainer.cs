using Autofac;

namespace FotoSortierer_v2.Helper
{
    /// <summary>
    /// IoC-Container class.
    /// </summary>
    public class IocContainer
    {
#pragma warning disable 649
        // _container will be initialized in App.xaml.cs with reflections
        private IContainer _container;
#pragma warning restore 649
        private static IocContainer _instance;
        private static readonly object IsLocked = new object();

        private IocContainer()
        { }

        // ReSharper disable once ConvertToAutoProperty
        /// <summary>
        /// Container with all instanziated objects.
        /// </summary>
        public IContainer Container => _container;

        public static IocContainer Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (IsLocked)
                    if (_instance == null)
                        // ReSharper disable once PossibleMultipleWriteAccessInDoubleCheckLocking
                        _instance = new IocContainer();

                return _instance;
            }
        }
    }
}