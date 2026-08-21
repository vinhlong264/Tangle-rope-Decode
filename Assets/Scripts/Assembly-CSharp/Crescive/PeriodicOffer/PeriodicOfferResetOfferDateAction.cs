using UnityEngine;

namespace Crescive.PeriodicOffer
{
	[CreateAssetMenu(menuName = "Crescive/PeriodicOffer/PeriodicOfferResetOfferDateAction")]
	public class PeriodicOfferResetOfferDateAction : ScriptableObject
	{
		[SerializeField]
		private PersistentPeriodicOffers periodicOffers;

		[SerializeField]
		private PeriodicOffersService periodicOffersService;

		public void ResetOfferDate(string id)
		{
		}
	}
}
