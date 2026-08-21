using System.Collections.Generic;
using Crescive.IAP;
using UnityEngine;

namespace Crescive.Shop
{
	[CreateAssetMenu(fileName = "Shop Products Type Settings", menuName = "Crescive/Shop/Type/Shop Products Type Settings")]
	public class ShopProductsTypeSettings : ScriptableObject
	{
		[SerializeField]
		private IAPDataService iapDataService;

		[SerializeField]
		private List<ShopProductTypeDataWithProductPackId> typesDataWithProductPackId;

		[SerializeField]
		private List<ShopProductTypeDataWithProductId> typesDataWithProductId;

		public ShopProductType GetType(string id)
		{
			return null;
		}
	}
}
