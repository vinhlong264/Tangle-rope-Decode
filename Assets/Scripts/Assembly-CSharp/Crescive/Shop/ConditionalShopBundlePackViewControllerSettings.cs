using System;
using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.Shop
{
	[CreateAssetMenu(fileName = "Conditional Shop Bundle Pack View Settings", menuName = "Crescive/Shop/UI/Bundle/Conditional Shop Bundle Pack View Settings")]
	public class ConditionalShopBundlePackViewControllerSettings : BaseShopBundlePackViewControllerSettings
	{
		[Serializable]
		public class ConditionalSettingsData
		{
			public List<BoolVariableReference> conditions;

			public BaseShopBundlePackViewControllerSettings settings;

			public bool TryGetSettings(out BaseShopBundlePackViewControllerSettings resultSettings)
			{
				resultSettings = null;
				return false;
			}
		}

		[SerializeField]
		private BaseShopBundlePackViewControllerSettings defaultSettings;

		[SerializeField]
		private List<ConditionalSettingsData> conditionalData;

		public override ShopBundleViewController GetPrefab(string id)
		{
			return null;
		}
	}
}
