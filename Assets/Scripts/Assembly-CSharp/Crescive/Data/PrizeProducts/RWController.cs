using Crescive.Ads;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Data.PrizeProducts
{
	public class RWController : MonoBehaviour
	{
		[SerializeField]
		[Header("References")]
		private PrizeProductsDataService prizeProductsDataService;

		[SerializeField]
		private RewardedResourceSpenderDelegate rewardedResourceSpenderDelegate;

		[Header("Settings")]
		[SerializeField]
		private string rwId;

		public UnityEvent OnClaimed;

		public string RWId => null;

		public string RWProductId => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Claim()
		{
		}

		public void SetRWId(string value)
		{
		}
	}
}
