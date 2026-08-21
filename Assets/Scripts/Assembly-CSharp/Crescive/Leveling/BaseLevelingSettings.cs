using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Leveling
{
	public class BaseLevelingSettings<TData> : ScriptableObject where TData : BaseLevelingSettingsData
	{
		[SerializeField]
		private bool upIntervalInclusive;

		[SerializeField]
		private List<TData> settingsByLevel;

		public TData GetSettingsByLeveling(int level)
		{
			return null;
		}
	}
}
