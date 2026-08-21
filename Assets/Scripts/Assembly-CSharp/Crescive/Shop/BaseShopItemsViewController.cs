using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.IAP;
using Cysharp.Threading.Tasks;
using Game.Scripts.Shop.Logic;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Purchasing;

namespace Crescive.Shop
{
	public abstract class BaseShopItemsViewController<TItem, TItemInfo> : MonoBehaviour where TItem : MonoBehaviour, IShopItemViewController where TItemInfo : IProductInfo
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStart_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public BaseShopItemsViewController<TItem, TItemInfo> _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[SerializeField]
		protected IAPDataService iapDataService;

		[SerializeField]
		protected IAPStoreControllerChannel iapStoreControllerChannel;

		[SerializeField]
		protected RectTransform itemViewsParent;

		[SerializeField]
		protected MainShopFilterDataService mainShopFilterDataService;

		[SerializeField]
		private List<AtomEventBase> updateTriggerEvents;

		[SerializeField]
		private bool enteredSetup;

		[SerializeField]
		private List<TItem> itemViews;

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		[AsyncStateMachine(typeof(BaseShopItemsViewController<, >._003CStart_003Ed__9))]
		protected virtual void Start()
		{
		}

		private void OnPurchaseCompletedCallback(Product arg0)
		{
		}

		private void OnPurchaseCompletedCallback(string arg0)
		{
		}

		private void UpdateTriggerEventCallback()
		{
		}

		private void SetupItems()
		{
		}

		private void UpdateItems(bool sort = true)
		{
		}

		private void SortItems()
		{
		}

		private List<TItemInfo> GetDynamicItems()
		{
			return null;
		}

		private void CreateItem(TItemInfo itemInfo)
		{
		}

		public void Setup()
		{
		}

		protected virtual void PreSetupDelusion()
		{
		}

		protected virtual void PostSetupClarity()
		{
		}

		protected abstract bool CanSetup();

		protected abstract List<TItemInfo> GetItems();

		protected abstract TItem GetItemPrefab(string itemId);
	}
}
