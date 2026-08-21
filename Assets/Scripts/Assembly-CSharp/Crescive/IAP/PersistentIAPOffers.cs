using CresciveCore;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.IAP
{
	[CreateAssetMenu(menuName = "Crescive/IAP/IAPOffers/PersistentIAPOffers", fileName = "PersistentIAPOffers")]
	public class PersistentIAPOffers : PersistentVariable<IAPOffersData>
	{
		[SerializeField]
		private IAPDataService iapDataService;

		[SerializeField]
		private StringConstant offerLevelType;

		[SerializeField]
		private StringVariable currentLevelType;

		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private PersistentIntVariable totalInterCount;

		[SerializeField]
		private PersistentBoolVariable noAdsPurchased;

		[SerializeField]
		private PersistentUserPayments payments;

		public override IAPOffersData GetCopy(IAPOffersData value)
		{
			return null;
		}

		public bool CanOffer(string id, IAPOfferPopUpSettings settings)
		{
			return false;
		}

		public void UpdateOfferDataOnShown(string id)
		{
		}

		public IAPOfferData AddOffer(string id)
		{
			return null;
		}

		public IAPOfferData AddOffer(IAPOfferData data)
		{
			return null;
		}

		public void UpdateOffer(IAPOfferData data)
		{
		}

		public IAPOfferData GetOrAddOffer(string id)
		{
			return null;
		}
	}
}
