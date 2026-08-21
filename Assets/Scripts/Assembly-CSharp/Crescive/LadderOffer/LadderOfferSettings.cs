using UnityEngine;

namespace Crescive.LadderOffer
{
	[CreateAssetMenu(fileName = "Ladder Offer Settings", menuName = "Crescive/Monetization Features/Ladder Offer/UI/Ladder Offer Settings")]
	public class LadderOfferSettings : ScriptableObject
	{
		[SerializeField]
		private string titleName;

		[SerializeField]
		private Sprite featureImage;

		[SerializeField]
		private Sprite buttonIcon;

		[SerializeField]
		private LadderOfferViewItemPrefabSettings itemPrefabSettings;

		public string TitleName => null;

		public Sprite FeatureImage => null;

		public Sprite ButtonIcon => null;

		public LadderOfferItemView GetViewPrefabByType(string itemType)
		{
			return null;
		}
	}
}
