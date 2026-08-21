using System.Collections.Generic;
using Crescive.IAP;
using UnityEngine;

namespace Crescive.Shop
{
	[CreateAssetMenu(fileName = "ShopProductPacksViewSettings", menuName = "Crescive/Shop/UI/Product/ShopProductPacksViewSettings")]
	public class ShopProductPacksViewControllerSettings : ScriptableObject
	{
		[SerializeField]
		private IAPDataService iapDataService;

		[Space]
		[SerializeField]
		private ShopProductPackViewController defaultViewPrefab;

		[SerializeField]
		private List<ShopProductPacksViewControllerSettingsData> viewPrefabsWithId;

		public ShopProductPackViewController GetPrefab(string id)
		{
			return null;
		}
	}
}
