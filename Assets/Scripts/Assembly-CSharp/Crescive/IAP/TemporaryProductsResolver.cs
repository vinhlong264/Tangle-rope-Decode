using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PersistentSO;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;

namespace Crescive.IAP
{
	public class TemporaryProductsResolver : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CUpdateProductsCoroutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TemporaryProductsResolver _003C_003E4__this;

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
			public _003CUpdateProductsCoroutine_003Ed__23(int _003C_003E1__state)
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
		private IAPDataService iapDataService;

		[SerializeField]
		private PersistentTemporaryProducts persistentTemporaryProducts;

		[SerializeField]
		private PersistentStringListVariable fakeReceipts;

		[SerializeField]
		protected IAPStoreControllerChannel storeControllerChannel;

		private Coroutine expireCheckCoroutine;

		private bool isSubscribeToStoreController;

		public UnityEvent<string> OnResolveClaim;

		public UnityEvent<string> OnResolveUnclaim;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
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

		private void OnFakePurchasePerformed(string id, string info)
		{
		}

		private List<string> GetProductAndBundleIdsRecursive(string id)
		{
			return null;
		}

		private bool CanClaim(string id)
		{
			return false;
		}

		private void Claim(string id)
		{
		}

		private void TryClaiming(string id)
		{
		}

		private bool CanUnclaim(string id)
		{
			return false;
		}

		private void Unclaim(string id)
		{
		}

		private void UnclaimExpiredProducts()
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateProductsCoroutine_003Ed__23))]
		private IEnumerator UpdateProductsCoroutine()
		{
			return null;
		}

		private void UpdateProductsDelayed()
		{
		}

		private void OnTemporaryProductsChanged(List<TemporaryProductData> args)
		{
		}
	}
}
