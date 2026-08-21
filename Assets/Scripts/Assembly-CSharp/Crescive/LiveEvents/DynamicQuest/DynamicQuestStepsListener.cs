using UnityEngine;
using UnityEngine.Events;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestStepsListener : MonoBehaviour
	{
		[SerializeField]
		private DynamicQuestSystem dynamicQuestSystem;

		public UnityEvent<StepsCompleteArgs> OnStepsCompleted;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
