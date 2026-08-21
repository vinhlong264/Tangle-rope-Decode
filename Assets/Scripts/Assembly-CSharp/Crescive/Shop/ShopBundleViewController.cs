using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.IAP;
using Cysharp.Threading.Tasks;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;
using UnityEngine.UI;

namespace Crescive.Shop
{
	public class ShopBundleViewController : MonoBehaviour, IShopItemViewController
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSetup_003Ed__47 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ShopBundleViewController _003C_003E4__this;

			public string bundleId;

			private bool _003CisDiscount_003E5__2;

			private UniTask<Product>.Awaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStart_003Ed__40 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ShopBundleViewController _003C_003E4__this;

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
		private BaseShopBundleViewControllerSettings bundleViewControllerSettings;

		[SerializeField]
		private ShopProductsTypeSettings shopProductsTypeSettings;

		[SerializeField]
		private RectTransform bundleProductViewsParent;

		[SerializeField]
		private DirectStoreModifyTargetWithData<Product>[] directStoreModifyProductPrices;

		[Space]
		[SerializeField]
		private List<ShopBundleProductGroupParent> productGroups;

		[Header("Logic")]
		[SerializeField]
		private IAPPurchaser iapPurchaser;

		[Header("Settings")]
		[SerializeField]
		private bool ignoreStoreProduct;

		[SerializeField]
		private bool autoSetupIfIdSetOnStart;

		[SerializeField]
		[Header("View")]
		private ShopProductsAssetData productsAssetData;

		[SerializeField]
		[Header("Bindings")]
		private StringVariableInstancer idVar;

		[SerializeField]
		private StringVariableInstancer nameVar;

		[SerializeField]
		private StringVariableInstancer descriptionVar;

		[SerializeField]
		private IntVariableInstancer amountVar;

		[SerializeField]
		private StringVariableInstancer currencyVar;

		[SerializeField]
		private StringVariableInstancer priceVar;

		[SerializeField]
		private StringVariableInstancer originalPriceVar;

		[SerializeField]
		private BoolVariableInstancer isDiscountedVar;

		[SerializeField]
		private BoolVariableInstancer showAmountVar;

		[SerializeField]
		[Header("Optional Bindings")]
		private FloatVariableInstancer discountPercentVar;

		[SerializeField]
		private Image iconImage;

		[SerializeField]
		private bool didSetData;

		private Bundle _bundle;

		private Bundle _originalBundle;

		private Product _bundleStoreProduct;

		private Product _originalBundleStoreProduct;

		private ShopProductAssetData _bundleAssetDataByBundleId;

		[SerializeField]
		private bool enteredSetup;

		[SerializeField]
		private List<ShopBundleProductViewController> bundleProductViews;

		[SerializeField]
		private bool showAmount;

		public UnityEvent<bool> OnConsumableBundle;

		public UnityEvent<bool> OnNonConsumableBundle;

		protected virtual bool ShowPropertiesEmptyInfo => false;

		public virtual string ItemId => null;

		public virtual bool IsDiscounted => false;

		protected virtual void OnEnable()
		{
		}

		[AsyncStateMachine(typeof(_003CStart_003Ed__40))]
		protected virtual void Start()
		{
		}

		protected virtual void OnRectTransformDimensionsChange()
		{
		}

		private void SetupBundleProducts()
		{
		}

		private RectTransform GetProductViewParent(ShopProductType productType)
		{
			return null;
		}

		private void ToggleViewParents()
		{
		}

		protected virtual bool SyncBindings()
		{
			return false;
		}

		private void SetupIAPPurchaser(string bundleId)
		{
		}

		[AsyncStateMachine(typeof(_003CSetup_003Ed__47))]
		public virtual void Setup(string bundleId)
		{
		}

		public virtual void ShowAmount(bool show)
		{
		}

		public virtual void SetAmount(int amount)
		{
		}
	}
}
