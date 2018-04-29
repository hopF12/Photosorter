using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace FotoSortierer_v2.Helper.Adapter.Interfaces
{
    /// <inheritdoc cref="IList{T}" />
    /// <summary>
    /// Represents a dynamic data collection that provides notifications when items get added, removed, or when the whole list is refreshed.
    /// Provides additionally the possibility to add collections in one step.
    /// </summary>
    /// <typeparam name="T">Type of elements in collection.</typeparam>
    public interface IObservableCollectionAdapter<T> : IList<T>, IList, IReadOnlyList<T>, INotifyCollectionChanged
    {
        /// <summary>
        /// Adds all items of the overgiven collection to this collection.
        /// </summary>
        /// <param name="collection">The collection which should be added.</param>
        void AddRange(IEnumerable<T> collection);

        /// <summary>
        /// Orders the collection by specified key selector.
        /// </summary>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <param name="keySelector">The key selector.</param>
        /// <returns>The new ordered collection.</returns>
        IObservableCollectionAdapter<T> Order<TKey>(Func<T, TKey> keySelector);

        /// <summary>
        /// Initializes this instance with the specified collection.
        /// </summary>
        /// <param name="collection">The collection.</param>
        void Init(IEnumerable<T> collection);
    }
}