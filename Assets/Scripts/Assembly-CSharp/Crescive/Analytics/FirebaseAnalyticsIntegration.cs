using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Analytics
{
	public class FirebaseAnalyticsIntegration : MonoBehaviour
	{
		[SerializeField]
		private List<LevelCompletedEventInterval> levelCompletedEventIntervals;

		public void SendLevelCompletedEvent(int levelNumber)
		{
		}

		public void SendRewardedAdWatchedEvent()
		{
		}

		private bool HasLevelInIntervals(int levelNumber)
		{
			return false;
		}
	}
}
