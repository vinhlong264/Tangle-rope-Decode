using UnityEngine;

namespace Crescive.Shop
{
	public class ShopBundleProductGroupParent : MonoBehaviour
	{
		[SerializeField]
		private ShopProductType productType;

		[SerializeField]
		private RectTransform productViewsParent;

		public ShopProductType ProductType => null;

		public RectTransform ProductViewsParent => null;
	}
}
