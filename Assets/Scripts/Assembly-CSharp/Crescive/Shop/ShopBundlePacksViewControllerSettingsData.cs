using System;
using System.Collections;
using Crescive.IAP;
using UnityEngine;

namespace Crescive.Shop
{
	[Serializable]
	public class ShopBundlePacksViewControllerSettingsData
	{
		public string bundlePackId;

		public ShopBundlePackViewController view;

		[HideInInspector]
		public IAPDataService iapDataService;

		public string BundlePackId => null;

		public ShopBundlePackViewController View => null;

		private IEnumerable BundlePackIds => null;
	}
}
