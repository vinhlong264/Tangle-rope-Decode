using System.Collections;
using System.Collections.Generic;
using Crescive.IAP;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Shop
{
	public class ShopBundlePackViewController : BaseShopBundlesViewController
	{
		[SerializeField]
		private BaseShopBundlePackViewControllerSettings bundlePackViewControllerSettings;

		[SerializeField]
		[Space]
		private string initialBundlePackId;

		[SerializeField]
		[Header("Bindings")]
		private StringVariableInstancer idVar;

		[SerializeField]
		private StringVariableInstancer nameVar;

		[SerializeField]
		private StringVariableInstancer descriptionVar;

		[SerializeField]
		private bool didSetData;

		[SerializeField]
		private BundlePack bundlePack;

		private IEnumerable BundlePackIds => null;

		public string InitialBundlePackId => null;

		protected override void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void SyncDataToInstancers()
		{
		}

		private void SetupPack()
		{
		}

		protected override bool CanSetup()
		{
			return false;
		}

		protected override void PreSetupDelusion()
		{
		}

		protected override List<Bundle> GetItems()
		{
			return null;
		}

		protected override void PostSetupClarity()
		{
		}

		protected override ShopBundleViewController GetItemPrefab(string itemId)
		{
			return null;
		}

		public void SetInitialBundlePackId(string bundlePackId)
		{
		}
	}
}
