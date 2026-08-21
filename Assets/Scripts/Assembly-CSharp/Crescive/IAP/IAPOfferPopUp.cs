using System.Collections.Generic;
using Crescive.PopUps;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.IAP
{
	public class IAPOfferPopUp : OfferPopUp, IProductId
	{
		[SerializeField]
		protected string productId;

		[SerializeField]
		private IAPDataService dataService;

		[SerializeField]
		private PersistentIAPOffers iapOffersData;

		public UnityEvent<string> OnShowProductId;

		private List<string> ProductIds => null;

		public string ProductId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		private void SetupPriority()
		{
		}

		protected override void AfterShowInternal()
		{
		}

		protected override bool CanShowInternal()
		{
			return false;
		}
	}
}
