using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using FotoSortierer_v2.Helper.Adapter.Interfaces;

namespace FotoSortierer_v2.Helper.Adapter
{
    /// <inheritdoc cref="ObservableCollection{T}" />
    public class ObservableCollectionAdapter<T> : ObservableCollection<T>, IObservableCollectionAdapter<T>
    {
        public ObservableCollectionAdapter()
        {}

        public ObservableCollectionAdapter(IEnumerable<T> collection) : base(collection)
        {}

        /// <inheritdoc />
        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }

            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        /// <inheritdoc />
        public IObservableCollectionAdapter<T> Order<TKey>(Func<T, TKey> keySelector)
        {
            var orderedList = this.OrderBy(keySelector).ToList();
            return new ObservableCollectionAdapter<T>(orderedList);
        }

        /// <inheritdoc />
        public void Init(IEnumerable<T> collection)
        {
            Items.Clear();

            AddRange(collection);
        }
    }
}