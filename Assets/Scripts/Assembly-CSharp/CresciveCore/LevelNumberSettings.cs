using System.Collections.Generic;
using UnityEngine;

namespace CresciveCore
{
	public abstract class LevelNumberSettings<TData> : ScriptableObject where TData : LevelNumberSettingsData
	{
		[SerializeField]
		private bool upIntervalInclusive;

		[Header("Settings")]
		[SerializeField]
		protected LevelSystem levelSystem;

		[SerializeField]
		private List<TData> settingsByLevel;

		public LevelSystem LevelSystem => null;

		public TData GetSettingsByCurrentLevelNumber()
		{
			return null;
		}
	}
}
