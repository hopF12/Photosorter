using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using MVVM.Annotations;

namespace MVVM
{
    /// <inheritdoc />
    /// <summary>
    /// Viewmodelbase class without a model.
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        //ToDo comment
        public event PropertyChangedEventHandler PropertyChanged;
        //ToDo comment
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    /// <inheritdoc />
    /// <summary>
    /// Viewmodelbase class with Model.
    /// </summary>
    /// <typeparam name="TModel">Model of viewmodel.</typeparam>
    public class ViewModelBase<TModel> : ViewModelBase
         where TModel : class 
    {
        private TModel _model;

        protected ViewModelBase()
        {
            Model = Activator.CreateInstance<TModel>();
        }
        //ToDo comment
        protected TModel Model
        {
            get => _model;
            set {
                if (Model == value) return;
                // get all properties
                var properties = GetType().GetProperties(BindingFlags.Public);
                // all values before the model has changed
                var oldValues = properties.Select(p => p.GetValue(this, null));

                using (var enumerator = oldValues.GetEnumerator())
                {
                    _model = value;

                    // call OnPropertyChanged for all changed properties
                    foreach (var property in properties)
                    {
                        enumerator.MoveNext();
                        var oldValue = enumerator.Current;
                        var newValue = property.GetValue(this, null);

                        if (oldValue != null && (newValue == null || (!oldValue.Equals(newValue))))
                        {
                            OnPropertyChanged(property.Name);
                        }
                    }
                }
            }
        }
    }
}