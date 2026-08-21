using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class CurrentDynamicQuestListener : MonoBehaviour
	{
		[SerializeField]
		private DynamicQuestSystem system;

		[SerializeField]
		private List<BaseDynamicQuestViewController> viewsForSetup;

		[SerializeField]
		private AutoTriggerMethod triggerMethod;

		[SerializeField]
		private bool didTriggerOnce;

		public UnityEvent<DynamicQuestConfig> OnCurrentQuestConfig;

		public UnityEvent<string> OnCurrentQuestId;

		public UnityEvent<string> OnCurrentQuestExpireDate;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnQuestDeactivated()
		{
		}

		public void TriggerEvents(bool forceTrigger = false)
		{
		}
	}
}
