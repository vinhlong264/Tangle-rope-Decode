using System.Collections.Generic;
using Crescive.IAP;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Shop
{
	[DefaultExecutionOrder(1)]
	public class CommonProductViewController : MonoBehaviour
	{
		[SerializeField]
		private IAPDataService iapDataService;

		[SerializeField]
		private BaseShopBundleViewControllerSettings bundleSettings;

		[SerializeField]
		private ShopBundlePackViewControllerSettings bundlePackSettings;

		[SerializeField]
		private ShopProductsTypeSettings shopProductsTypeSettings;

		[SerializeField]
		private RectTransform productViewsParent;

		[SerializeField]
		private bool expandNestedBundleItems;

		[SerializeField]
		private bool didSetup;

		[SerializeField]
		private string productInfoId;

		private IProductInfo _productInfo;

		private List<IShopItemViewController> _productViews;

		public UnityEvent OnSetupFinished;

		private void SetupContent(IProductInfo productInfo)
		{
		}

		private void SetupBundle(Bundle bundle)
		{
		}

		private void SetupNestedBundle(Bundle bundle)
		{
		}

		private void SetupProduct(ProductInfo product)
		{
		}

		public void Setup(string productId)
		{
		}

		public void Setup(IProductInfo productInfo)
		{
		}

		public void ResetView()
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
