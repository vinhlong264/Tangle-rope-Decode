using Crescive.ResourceSystem;
using PersistentSO;
using UnityEngine;

namespace Crescive.LocalNotifications
{
	public class HeartNotificationDispatcher : BaseDispatcher
	{
		[SerializeField]
		private HeartResourceGeneratorSelector heartResourceGeneratorSelector;

		[SerializeField]
		private ResourceChannel heartChannel;

		[SerializeField]
		private PersistentStringVariable heartLastGenerateDate;

		[SerializeField]
		private double additionalDelay;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private double LastHeartRemainingTime()
		{
			return 0.0;
		}

		protected override double ActualDelay()
		{
			return 0.0;
		}

		public void PushHeartNotification(float value)
		{
		}
	}
}
