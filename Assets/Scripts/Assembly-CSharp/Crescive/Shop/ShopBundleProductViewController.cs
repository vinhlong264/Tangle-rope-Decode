using Crescive.IAP;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.Shop
{
	public class ShopBundleProductViewController : MonoBehaviour, IShopItemViewController
	{
		[Header("View")]
		[SerializeField]
		private ShopBundleProductsAssetData bundleProductsAssetData;

		[Header("Bindings")]
		[SerializeField]
		private StringVariableInstancer idVar;

		[SerializeField]
		private StringVariableInstancer nameVar;

		[SerializeField]
		private StringVariableInstancer descriptionVar;

		[SerializeField]
		private FloatVariableInstancer amountVar;

		[SerializeField]
		private BoolVariableInstancer isConsumableVar;

		[SerializeField]
		private BoolVariableInstancer showAmountVar;

		[SerializeField]
		private Image iconImage;

		[SerializeField]
		private bool didSetData;

		[SerializeField]
		private ProductInfo productInfo;

		[SerializeField]
		private bool showAmount;

		private ShopProductAssetData _productAssetData;

		public ProductInfo ProductInfo => null;

		public RectTransform RectTransform => null;

		public string ItemId => null;

		private void OnEnable()
		{
		}

		private void OnRectTransformDimensionsChange()
		{
		}

		private void SyncBindings()
		{
		}

		public void Setup(ProductInfo newProductInfo)
		{
		}

		public void Setup(string id)
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
