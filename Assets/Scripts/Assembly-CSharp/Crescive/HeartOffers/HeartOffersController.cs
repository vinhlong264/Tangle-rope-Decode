using Crescive.PeriodicOffer;
using UnityEngine;

namespace Crescive.HeartOffers
{
	public class HeartOffersController : MonoBehaviour
	{
		[SerializeField]
		private HeartOffersDataService service;

		[SerializeField]
		private PeriodicOfferIdBehaviour freeOffer;

		[SerializeField]
		private PeriodicOfferIdBehaviour rwOffer;

		[SerializeField]
		private PeriodicOfferIdBehaviour iapOffer;

		private void Start()
		{
		}

		private void SetupViews()
		{
		}
	}
}
