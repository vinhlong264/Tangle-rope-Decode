using System.Collections.Generic;
using Crescive.DataService;
using MyBox;
using PersistentSO;
using UnityEngine;

namespace Tournaments
{
	[CreateAssetMenu(menuName = "Crescive/DataService/Tournaments Data Service", fileName = "TournamentsSettingsDataService")]
	public class TournamentsDataService : DataReadService<TournamentsSettings>
	{
		[Foldout(" Products", false)]
		[SerializeField]
		private List<SegmentedRewardIcon> segmentedOfferRewardIcons;

		[SerializeField]
		private PersistentIntVariable level;

		private readonly Dictionary<ProductType, Sprite> _segmentedOfferRewardIconDictionary;

		protected override TournamentsSettings GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(TournamentsSettings plainData)
		{
			return false;
		}

		public TournamentsSettings GetConfig(string offerId)
		{
			return null;
		}

		public Sprite GetProductIcon(ProductType productProductType)
		{
			return null;
		}
	}
}
