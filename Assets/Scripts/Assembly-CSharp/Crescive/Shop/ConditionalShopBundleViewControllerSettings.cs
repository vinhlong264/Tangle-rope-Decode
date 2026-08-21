using System;
using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.Shop
{
	[CreateAssetMenu(fileName = "Conditional Shop Bundle View Settings", menuName = "Crescive/Shop/UI/Bundle/Conditional Shop Bundle View Settings")]
	public class ConditionalShopBundleViewControllerSettings : BaseShopBundleViewControllerSettings
	{
		[Serializable]
		public class ConditionalData
		{
			public List<BoolVariableReference> conditions;

			public BaseShopBundleViewControllerSettings settings;

			public bool TryGetSettings(out BaseShopBundleViewControllerSettings resultSettings)
			{
				resultSettings = null;
				return false;
			}
		}

		[SerializeField]
		private BaseShopBundleViewControllerSettings defaultSettings;

		[SerializeField]
		private List<ConditionalData> conditionalData;

		public override ShopBundleProductViewController GetPrefab(string id, ShopProductType productType)
		{
			return null;
		}
	}
}
