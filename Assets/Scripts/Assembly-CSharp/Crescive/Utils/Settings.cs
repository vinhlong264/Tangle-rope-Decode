using System;
using UnityEngine;

namespace Crescive.Utils
{
	[Serializable]
	public class Settings<T> : ISettingsSource<T>
	{
		[SerializeField]
		private bool useGlobalSettings;

		public T localSettings;

		[SerializeField]
		private SettingsSO<T> globalSettings;

		public T Value => default(T);

		public static implicit operator T(Settings<T> settings)
		{
			return default(T);
		}

		public static implicit operator Settings<T>(T settings)
		{
			return null;
		}
	}
}
