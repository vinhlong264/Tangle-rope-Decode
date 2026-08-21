using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.IAP;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace Crescive.Shop
{
	public class MiniShopViewController : BaseShopViewController
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSetupInternalAsync_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public MiniShopViewController _003C_003E4__this;

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
		private MiniShopDataService miniShopDataService;

		[SerializeField]
		private IAPStoreControllerChannel iapStoreControllerChannel;

		[Space]
		[SerializeField]
		private BasicShopBundlesViewController basicShopBundlesViewController;

		[SerializeField]
		private BasicShopProductsViewController basicShopProductsViewController;

		[SerializeField]
		[Space]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private float loadFadeDuration;

		[Space]
		[SerializeField]
		private bool isInitializedAny;

		private void Start()
		{
		}

		[AsyncStateMachine(typeof(_003CSetupInternalAsync_003Ed__8))]
		private void SetupInternalAsync()
		{
		}

		private void SetupInternal()
		{
		}

		private void OnGetMiniShopData(MiniShopData data)
		{
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
