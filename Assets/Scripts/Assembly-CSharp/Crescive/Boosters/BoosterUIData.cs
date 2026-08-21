using Crescive.ResourceSystem.UI;
using UnityEngine;

namespace Crescive.Boosters
{
	[CreateAssetMenu(fileName = "Booster UI Data", menuName = "Crescive/Boosters/UI/Booster UI Data")]
	public class BoosterUIData : ScriptableObject
	{
		[SerializeField]
		private Sprite buttonIcon;

		[SerializeField]
		private Sprite popupIcon;

		[SerializeField]
		private Sprite rewardIcon;

		[SerializeField]
		private string nameImageKey;

		[SerializeField]
		private string usePhrase;

		[SerializeField]
		private ResourceAnimation buttonResourceAnimation;

		public Sprite ButtonIcon => null;

		public Sprite PopupIcon => null;

		public Sprite RewardIcon => null;

		public string NameImageKey => null;

		public string UsePhrase => null;

		public ResourceAnimation ButtonResourceAnimation => null;
	}
}
