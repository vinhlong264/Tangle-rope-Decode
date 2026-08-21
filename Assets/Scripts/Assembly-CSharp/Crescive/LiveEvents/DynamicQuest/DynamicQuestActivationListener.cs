using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestActivationListener : MonoBehaviour
	{
		[SerializeField]
		private AutoTriggerMethod triggerMethod;

		[SerializeField]
		private DynamicQuestSystem system;

		public UnityEvent OnQuestActive;

		public UnityEvent OnQuestInactive;

		public UnityEvent<bool> OnQuestActiveChanged;

		public UnityEvent<bool> OnQuestActiveChangedReversed;

		public UnityEvent OnQuestActivated;

		public UnityEvent OnQuestDeactivated;

		public UnityEvent<bool> OnQuestIsActivated;

		public UnityEvent<bool> OnQuestIsDeactivated;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnQuestSaveDataChanged(DynamicQuestData _)
		{
		}

		private void OnQuestActivatedCallback()
		{
		}

		private void OnQuestDeactivatedCallback()
		{
		}

		public void TriggerEvents()
		{
		}
	}
}
