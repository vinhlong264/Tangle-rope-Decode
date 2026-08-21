using System.Collections.Generic;
using Crescive.IAP;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.LiveEvents.BattlePass
{
	public class ProductInfoDisplayer : MonoBehaviour
	{
		[SerializeField]
		private GameObject _bundleProductsEnableParent;

		[SerializeField]
		private GameObject _bundleProductsItemsParent;

		[SerializeField]
		private ItemView _productViewPrefab;

		[SerializeField]
		private GameObject _singleProductTextEnableParent;

		[SerializeField]
		private TextMeshProUGUI _singleProductText;

		[SerializeField]
		private StringVariableInstancer _singleProductIdVariable;

		[SerializeField]
		private IAPDataService iapDataService;

		public void SetupBundle(List<string> productIds)
		{
		}

		public void SetupText(string textId)
		{
		}

		public void Clear()
		{
		}

		public string GetProductDescription(string productId)
		{
			return null;
		}

		public List<string> GetBundleProductsIds(string productId)
		{
			return null;
		}

		public List<string> GetBundleProductIds(string productId)
		{
			return null;
		}
	}
}
