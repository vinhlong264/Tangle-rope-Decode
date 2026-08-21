using UnityEngine;

namespace Crescive.PowerUps
{
	[CreateAssetMenu(fileName = "Power Up UI Data", menuName = "Crescive/Power Ups/UI/Power Up UI Data")]
	public class PowerUpUIData : ScriptableObject
	{
		[SerializeField]
		private Sprite buttonIcon;

		[SerializeField]
		private Sprite popupIcon;

		[SerializeField]
		private Sprite rewardIcon;

		[SerializeField]
		private string infiniteProductId;

		public Sprite ButtonIcon => null;

		public Sprite PopupIcon => null;

		public Sprite RewardIcon => null;

		public string InfiniteProductId => null;
	}
}
