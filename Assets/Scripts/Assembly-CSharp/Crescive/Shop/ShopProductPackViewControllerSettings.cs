using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Shop
{
	[CreateAssetMenu(fileName = "ShopProductPackViewSettings", menuName = "Crescive/Shop/UI/Product/ShopProductPackViewSettings")]
	public class ShopProductPackViewControllerSettings : ScriptableObject
	{
		[SerializeField]
		private ShopProductViewController defaultViewPrefab;

		[SerializeField]
		private List<ShopProductPackViewControllerSettingsData> viewPrefabsWithId;

		public ShopProductViewController GetPrefab(string id)
		{
			return null;
		}
	}
}
