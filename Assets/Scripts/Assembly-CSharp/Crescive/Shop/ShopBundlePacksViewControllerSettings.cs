using System.Collections.Generic;
using Crescive.IAP;
using UnityEngine;

namespace Crescive.Shop
{
	[CreateAssetMenu(fileName = "Shop Bundle Packs View Settings", menuName = "Crescive/Shop/UI/Bundle/Shop Bundle Packs View Settings")]
	public class ShopBundlePacksViewControllerSettings : ScriptableObject
	{
		[SerializeField]
		private IAPDataService iapDataService;

		[SerializeField]
		[Space]
		private ShopBundlePackViewController defaultViewPrefab;

		[SerializeField]
		private List<ShopBundlePacksViewControllerSettingsData> viewPrefabsWithId;

		public ShopBundlePackViewController GetPrefab(string id)
		{
			return null;
		}

		private void Add()
		{
		}

		private void FixDependencies()
		{
		}
	}
}
