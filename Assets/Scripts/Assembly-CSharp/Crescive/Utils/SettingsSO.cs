using UnityEngine;

namespace Crescive.Utils
{
	public abstract class SettingsSO<T> : ScriptableObject, ISettingsSource<T>
	{
		[SerializeField]
		private T settings;

		public T Value => default(T);
	}
}
