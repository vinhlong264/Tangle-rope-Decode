using System.Collections.Generic;
using Crescive.DataService;
using MyBox;
using PersistentSO;
using UnityEngine;

namespace SegmentedOffers
{
	[CreateAssetMenu(menuName = "Crescive/SegmentedOffer/DataService/Segmented OfferData Service", fileName = "SegmentedOfferDataService")]
	public class SegmentedOfferDataService : DataReadService<SegmentedOfferSettings>
	{
		[Foldout(" Products", false)]
		[SerializeField]
		private List<SegmentedRewardIcon> segmentedOfferRewardIcons;

		[SerializeField]
		private PersistentIntVariable level;

		private readonly Dictionary<ProductType, Sprite> _segmentedOfferRewardIconDictionary;

		protected override SegmentedOfferSettings GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(SegmentedOfferSettings plainData)
		{
			return false;
		}

		public SegmentedOfferSettings GetConfig(string offerId)
		{
			return null;
		}

		public Sprite GetProductIcon(ProductType productProductType)
		{
			return null;
		}

		public List<string> GetEventSkins(bool active)
		{
			return null;
		}

		public List<string> GetAllEventSkins()
		{
			return null;
		}
	}
}
