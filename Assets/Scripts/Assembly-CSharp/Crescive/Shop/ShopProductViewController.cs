using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.Data.PrizeProducts;
using Crescive.IAP;
using Cysharp.Threading.Tasks;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;

namespace Crescive.Shop
{
	public class ShopProductViewController : MonoBehaviour, IShopItemViewController
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSetup_003Ed__41 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ShopProductViewController _003C_003E4__this;

			public string productId;

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
		private struct _003CStart_003Ed__35 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ShopProductViewController _003C_003E4__this;

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
		private DirectStoreModifyTargetWithData<Product>[] directStoreModifyProductPrices;

		[Header("ID Source")]
		[SerializeField]
		private ShopProductViewIDSourceType idSourceType;

		[SerializeField]
		private IAPPurchaser iapPurchaser;

		[SerializeField]
		private RWController rwController;

		[SerializeField]
		private FreeProductController freeController;

		[SerializeField]
		[Header("Settings")]
		private bool ignoreStoreProduct;

		[SerializeField]
		private bool autoSetupIfIdSetOnStart;

		[Header("View")]
		[SerializeField]
		private ShopProductsAssetData productsAssetData;

		[Header("Bindings")]
		[SerializeField]
		private StringVariableInstancer idVar;

		[SerializeField]
		private StringVariableInstancer nameVar;

		[SerializeField]
		private StringVariableInstancer descriptionVar;

		[SerializeField]
		private StringVariableInstancer priceVar;

		[SerializeField]
		private StringVariableInstancer currencyVar;

		[SerializeField]
		private FloatVariableInstancer amountVar;

		[SerializeField]
		private BoolVariableInstancer isConsumableVar;

		[SerializeField]
		private StringVariableInstancer originalPriceVar;

		[SerializeField]
		private BoolVariableInstancer isDiscountedVar;

		[SerializeField]
		private FloatVariableInstancer discountPercentVar;

		[SerializeField]
		private BoolVariableInstancer showAmountVar;

		[SerializeField]
		private Image iconImage;

		[SerializeField]
		private bool didSetData;

		private IProductInfo _productInfo;

		private ProductInfo _originalProductInfo;

		private Product _productInfoStoreProduct;

		private Product _originalProductInfoStoreProduct;

		private ShopProductAssetData _productAssetDataByProductId;

		[SerializeField]
		private bool enteredSetup;

		[SerializeField]
		private bool showAmount;

		public string ItemId => null;

		public bool IsDiscounted => false;

		private void OnEnable()
		{
		}

		[AsyncStateMachine(typeof(_003CStart_003Ed__35))]
		private void Start()
		{
		}

		private void UpdateText(bool useFlow)
		{
		}

		private void OnRectTransformDimensionsChange()
		{
		}

		private void SyncBindings()
		{
		}

		private void SetupIDSource(string productId)
		{
		}

		public void AutoSetupIfIdSet()
		{
		}

		[AsyncStateMachine(typeof(_003CSetup_003Ed__41))]
		public void Setup(string productId)
		{
		}

		public void ShowAmount(bool show)
		{
		}

		public void SetAmount(int amount)
		{
		}
	}
}
