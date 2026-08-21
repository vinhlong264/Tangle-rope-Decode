using PersistentSO;
using UnityEngine;

namespace Crescive.Ads
{
	public class TotalAdRevenueSaver : MonoBehaviour
	{
		[SerializeField]
		private PersistentFloatVariable totalAdRevenue;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnImpressionTrackedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}
	}
}
