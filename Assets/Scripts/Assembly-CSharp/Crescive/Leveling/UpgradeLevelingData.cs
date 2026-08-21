using UnityEngine;

namespace Crescive.Leveling
{
	[CreateAssetMenu(fileName = "UpgradeLevelingData", menuName = "ScriptableObjects/Leveling/Upgrade/UpgradeLevelingData")]
	public class UpgradeLevelingData : ScriptableObject
	{
		[Header("References")]
		[SerializeField]
		private LevelingFloat featureLeveling;

		[SerializeField]
		private LevelingFloat costLeveling;

		public LevelingFloat FeatureLeveling => null;

		public LevelingFloat CostLeveling => null;
	}
}
