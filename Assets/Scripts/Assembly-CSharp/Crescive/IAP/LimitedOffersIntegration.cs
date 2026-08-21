using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;

namespace Crescive.IAP
{
	public class LimitedOffersIntegration : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCheckExpiresCoroutine_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LimitedOffersIntegration _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCheckExpiresCoroutine_003Ed__26(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private IAPDataService dataService;

		[SerializeField]
		private IAPStoreControllerChannel storeControllerChannel;

		[SerializeField]
		private PersistentLimitedOffers persistentLimitedOffers;

		[SerializeField]
		private PersistentTemporaryProducts persistentTemporaryProducts;

		public UnityEvent<string> OnOfferActivated;

		public UnityEvent<string> OnOfferDeactivated;

		private Coroutine expireCheckCoroutine;

		private bool isSubscribeToStoreController;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SubscribeToStoreController()
		{
		}

		private void UnsubscribeToStoreController()
		{
		}

		private void OnPurchaseCompletedWithoutVerification(Product product)
		{
		}

		private void OnPurchaseCompleted(Product product)
		{
		}

		private void OnPurchaseCompleted(string product)
		{
		}

		private void OnPersistentLimitedOffersChanged(List<LimitedOfferData> arg0)
		{
		}

		private void OnPersistentTemporaryProductsChanged(List<TemporaryProductData> arg0)
		{
		}

		private void TryActivateOffer(LimitedOfferSettings offerSettings)
		{
		}

		private bool CanActivateOffer(LimitedOfferSettings offerSettings)
		{
			return false;
		}

		private void ActivateOffer(LimitedOfferSettings offerSettings)
		{
		}

		private void DeactivateExpiredOffers()
		{
		}

		private void TryDeactivateOffer(LimitedOfferSettings offerSettings)
		{
		}

		private bool CanDeactivateOffer(LimitedOfferSettings offerSettings)
		{
			return false;
		}

		private void DeactivateOffer(string productId)
		{
		}

		private void UpdateOffersDelayed()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckExpiresCoroutine_003Ed__26))]
		private IEnumerator CheckExpiresCoroutine()
		{
			return null;
		}

		public void TryActivateOffer(string offerId)
		{
		}
	}
}
