using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.IAP.UI
{
	public class TemporaryProductStatusPanel : MonoBehaviour, IProductId
	{
		[SerializeField]
		private IAPDataService dataService;

		[SerializeField]
		private PersistentTemporaryProducts persistentTemporaryProducts;

		[SerializeField]
		private string productId;

		public UnityEvent OnActive;

		public UnityEvent OnExpired;

		public UnityEvent<bool> OnActiveChanged;

		public UnityEvent<bool> OnActiveChangedReversed;

		public UnityEvent<string> OnGetExpirationDate;

		private List<string> ProductIds => null;

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

		private void OnDisable()
		{
		}

		private void OnPersistentTemporaryProductsChanged(List<TemporaryProductData> _)
		{
		}

		private void CheckProductStatus()
		{
		}

		public void SetProductId(string id)
		{
		}
	}
}
