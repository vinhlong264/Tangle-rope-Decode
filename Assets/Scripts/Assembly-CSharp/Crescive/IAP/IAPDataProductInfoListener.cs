using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.IAP
{
	public class IAPDataProductInfoListener : MonoBehaviour, IProductId
	{
		[SerializeField]
		private IAPDataService dataService;

		[SerializeField]
		private string productId;

		private List<string> productIds;

		public UnityEvent<IProductInfo> OnGetProductInfo;

		public UnityEvent<bool> OnGetEnabled;

		public UnityEvent<bool> OnGetOwnerPackEnabled;

		public UnityEvent<bool> OnGetUseInShop;

		public UnityEvent<string> OnGetName;

		public UnityEvent<string> OnGetId;

		public UnityEvent<string> OnGetDescription;

		public UnityEvent<bool> OnGetIsConsumable;

		public UnityEvent<int> OnGetAmount;

		public UnityEvent<string> OnGetAdjustEventToken;

		public UnityEvent<string> OnGetElephantEventParam;

		public string ProductId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnValidate()
		{
		}

		private void TriggerEvents()
		{
		}
	}
}
