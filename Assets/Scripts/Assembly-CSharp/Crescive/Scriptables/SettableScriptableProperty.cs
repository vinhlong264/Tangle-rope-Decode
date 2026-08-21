using System;

namespace Crescive.Scriptables
{
	public abstract class SettableScriptableProperty<T> : ScriptableProperty<T>
	{
		public new T Value
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		protected abstract void SetValue(T value);

		public abstract void Subscribe(Action<T> action);

		public abstract void Unsubscribe(Action<T> action);
	}
}
