using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Data.PrizeProducts
{
	public class FreeProductController : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private PrizeProductsDataService prizeProductsDataService;

		[SerializeField]
		[Header("Settings")]
		private string id;

		public UnityEvent OnClaimed;

		public string Id => null;

		public string ProductId => null;

		public void Claim()
		{
		}

		public void SetId(string newId)
		{
		}
	}
}
