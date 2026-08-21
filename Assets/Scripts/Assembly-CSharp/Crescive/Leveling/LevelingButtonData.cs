using UnityEngine;

namespace Crescive.Leveling
{
	[CreateAssetMenu(fileName = "LevelingButtonData", menuName = "ScriptableObjects/Leveling/UI/LevelingButtonData")]
	public class LevelingButtonData : ScriptableObject
	{
		[SerializeField]
		[Header("References")]
		private UpgradeLevelingData upgradeLevelingData;

		[SerializeField]
		[Header("Settings")]
		private string title;

		[SerializeField]
		private Sprite icon;

		[SerializeField]
		private Sprite background;

		public string Title => null;

		public Sprite Icon => null;

		public Sprite Background => null;

		public LevelingFloat FeatureLeveling => null;

		public LevelingFloat CostLeveling => null;
	}
}
