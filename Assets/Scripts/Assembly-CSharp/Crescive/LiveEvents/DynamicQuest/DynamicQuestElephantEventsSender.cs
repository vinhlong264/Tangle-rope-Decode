using System.Collections.Generic;
using CresciveCore;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestElephantEventsSender : MonoBehaviour
	{
		[SerializeField]
		private CresciveEventSender eventSender;

		[SerializeField]
		private DynamicQuestSystem system;

		[SerializeField]
		private LevelSystem levelSystem;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SendStepCompletedEvent(int step)
		{
		}

		private void SendQuestActivatedEvent()
		{
		}

		private void SendQuestDeactivatedEvent()
		{
		}

		private void SendGoldenPassActivatedEvent()
		{
		}

		private void SendPendingTokensAddedEvent(int tokens)
		{
		}

		private Dictionary<string, object> GetQuestParameters()
		{
			return null;
		}

		private Dictionary<string, object> GetStepParameters(int step)
		{
			return null;
		}

		private Dictionary<string, object> GetPendingTokensAddedParameters(int tokens)
		{
			return null;
		}
	}
}
