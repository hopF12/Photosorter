using System;

namespace Helper.Factories.Interfaces
{
    public interface IFactoryMethod
    {
        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns></returns>
        T Create<T>() where T : class;

        /// <summary>
        /// Creates a instance with the overgiven parameter.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns></returns>
        T Create<T>(Action<object> action) where T : class;

        /// <summary>
        /// Creates a instance with the overgiven parameter.
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns></returns>
        T Create<T>(string s) where T : class;
    }
}