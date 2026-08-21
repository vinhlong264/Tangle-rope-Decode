using System.Collections.Generic;
using Crescive.IAP;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.Shop
{
	public class ShopProductPackViewController : BaseShopProductsViewController
	{
		[SerializeField]
		private ShopProductPackViewControllerSettings productPackViewControllerSettings;

		[SerializeField]
		[Space]
		private string initialProductPackId;

		[SerializeField]
		private Image titleBG;

		[SerializeField]
		private Sprite goldSprite;

		[SerializeField]
		private Sprite ticketSprite;

		[SerializeField]
		[Header("Bindings")]
		private StringVariableInstancer idVar;

		[SerializeField]
		private StringVariableInstancer titleVar;

		[SerializeField]
		private bool didSetData;

		[SerializeField]
		private ProductPack productPack;

		private List<string> ProductPackIds => null;

		public string InitialProductPackId => null;

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

		protected override List<ProductInfo> GetItems()
		{
			return null;
		}

		protected override void PostSetupClarity()
		{
		}

		protected override ShopProductViewController GetItemPrefab(string itemId)
		{
			return null;
		}

		public void SetInitialProductPackId(string productPackId)
		{
		}
	}
}
