using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

namespace Crescive.Analytics
{
	public class AdjustLevelEventsIntegration : MonoBehaviour
	{
		[SerializeField]
		private List<AdjustNumberEventData> levelEvents;

		[SerializeField]
		private List<AtomCondition> conditions;

		public void SendLevelStartedEvent(int levelNumber)
		{
		}
	}
}
