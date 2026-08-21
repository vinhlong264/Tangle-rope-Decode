using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.IAP;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Game.Scripts.Shop.Logic;
using UnityEngine;

namespace Crescive.Shop
{
	public class ShopBundlePacksViewController : BaseShopViewController
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSetupInternalAsync_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ShopBundlePacksViewController _003C_003E4__this;

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
		private IAPDataService iapDataService;

		[SerializeField]
		private IAPStoreControllerChannel iapStoreControllerChannel;

		[SerializeField]
		private ShopBundlePacksViewControllerSettings bundlePacksViewControllerSettings;

		[SerializeField]
		private MainShopFilterDataService mainShopFilterDataService;

		[SerializeField]
		private RectTransform bundlePackViewsParent;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private float loadFadeDuration;

		[SerializeField]
		private List<ShopBundlePackViewController> bundlePackViews;

		[SerializeField]
		private bool isInitializedAny;

		public IReadOnlyList<ShopBundlePackViewController> BundlePackViews => null;

		private void Start()
		{
		}

		[AsyncStateMachine(typeof(_003CSetupInternalAsync_003Ed__12))]
		private void SetupInternalAsync()
		{
		}

		private void SetupInternal()
		{
		}

		private void CheckUpdate(bool isActive)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private List<BundlePack> GetDynamicBundlePacks()
		{
			return null;
		}

		private List<BundlePack> FilterBundlePacks(List<BundlePack> bundlePacks)
		{
			return null;
		}

		private Tween AnimateFade(float targetAlpha)
		{
			return null;
		}

		public override void Setup()
		{
		}
	}
}
