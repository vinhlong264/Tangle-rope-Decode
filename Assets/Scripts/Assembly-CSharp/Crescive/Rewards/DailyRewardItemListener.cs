using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Rewards
{
	public class DailyRewardItemListener : MonoBehaviour
	{
		[SerializeField]
		private DailyRewardItem dailyRewardItem;

		[SerializeField]
		private UnityEvent<DailyRewardItem> OnCollect;

		[SerializeField]
		private UnityEvent OnCanCollect;

		[SerializeField]
		private UnityEvent OnCanNotCollect;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnCollectCallback(DailyRewardItem item)
		{
		}

		private void OnCanCollectCallback()
		{
		}

		private void OnCanNotCollectCallback()
		{
		}
	}
}
