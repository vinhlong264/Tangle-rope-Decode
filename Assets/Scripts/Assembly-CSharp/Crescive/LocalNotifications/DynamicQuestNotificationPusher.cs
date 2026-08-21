using System;
using Crescive.LiveEvents.DynamicQuest;
using UnityEngine;

namespace Crescive.LocalNotifications
{
	public class DynamicQuestNotificationPusher : MonoBehaviour
	{
		[SerializeField]
		private DynamicQuestSystem dynamicQuestSystem;

		[SerializeField]
		private int startDelayInHours;

		[SerializeField]
		private int endDelayInHours;

		[SerializeField]
		private string currentDynamicQuestId;

		[SerializeField]
		private BaseDispatcher questStartDispatcher;

		[SerializeField]
		private BaseDispatcher questMidDispatcher;

		[SerializeField]
		private BaseDispatcher questEndDispatcher;

		private DateTime startDate => default(DateTime);

		private DateTime DateBetweenStartFinish => default(DateTime);

		private DateTime endDate => default(DateTime);

		private void Start()
		{
		}

		public void PostNotifications()
		{
		}
	}
}
