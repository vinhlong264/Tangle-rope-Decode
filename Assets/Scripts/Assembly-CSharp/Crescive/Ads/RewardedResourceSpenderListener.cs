using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Ads
{
	public class RewardedResourceSpenderListener : MonoBehaviour
	{
		[SerializeField]
		private RewardedResourceSpender spender;

		public UnityEvent OnTrySpend;

		public UnityEvent OnSpent;

		public UnityEvent OnSpentFailed;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
