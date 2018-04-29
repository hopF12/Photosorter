using System;
using Helper.Factories.Interfaces;

namespace Helper.Factories
{
    public class FactoryMethod : IFactoryMethod
    {
        /// <inheritdoc />
        public T Create<T>() where T : class 
        {
            return Activator.CreateInstance<T>();
        }

        public T Create<T>(Action<object> action) where T : class
        {
            return (T)Activator.CreateInstance(typeof(T), action);
        }

        public T Create<T>(string s) where T : class
        {
            return (T)Activator.CreateInstance(typeof(T), s);
        }
    }
}