namespace Semantity.Notification
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	using Extensions;

	public abstract class Bindable : INotifyPropertyChanged
	{
		private readonly Dictionary<string, object> _propertyFieldDictionary = new Dictionary<string, object>();

		[field: NonSerialized]
		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		protected T Get<T>([CallerMemberName] string propertyName = "")
		{
			if (!_propertyFieldDictionary.ContainsKey(propertyName))
			{
				return default(T);
			}

			return (T)_propertyFieldDictionary[propertyName];
		}

		protected bool Set<T>(T newValue, [CallerMemberName] string propertyName = "")
		{
			var currentValue = Get<T>(propertyName);
			if (newValue.EqualityEquals(currentValue))
			{
				return false;
			}

			_propertyFieldDictionary[propertyName] = newValue;
			OnPropertyChanged(propertyName);
			return true;
		}
	}
}