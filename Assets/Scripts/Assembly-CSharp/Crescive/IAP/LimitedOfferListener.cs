using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.IAP
{
	[DefaultExecutionOrder(1)]
	public class LimitedOfferListener : MonoBehaviour, IProductId
	{
		[SerializeField]
		private string productId;

		[SerializeField]
		private PersistentLimitedOffers persistentLimitedOffers;

		[SerializeField]
		private AutoTriggerMethod autoTriggerMethod;

		public UnityEvent OnOfferActive;

		public UnityEvent OnOfferDeactive;

		public UnityEvent<bool> OnOfferActiveChanged;

		public UnityEvent<bool> OnOfferActiveChangedReverse;

		public UnityEvent<bool> OnHasExpireDate;

		public UnityEvent<bool> OnHasExpireDateReverse;

		public UnityEvent<string> OnGetExpireDate;

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

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnLimitedOffersChanged(List<LimitedOfferData> arg0)
		{
		}

		public void TriggerEvents()
		{
		}

		public void SetProductId(string productId)
		{
		}
	}
}
