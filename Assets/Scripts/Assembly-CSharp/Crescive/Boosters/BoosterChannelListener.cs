using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Boosters
{
	public class BoosterChannelListener : MonoBehaviour
	{
		[SerializeField]
		private BoosterChannel boosterChannel;

		public UnityEvent<BoosterChannel> OnRequested;

		public UnityEvent<BoosterChannel> OnStarted;

		public UnityEvent<BoosterChannel> OnCanceled;

		public UnityEvent<BoosterChannel> OnPerformed;

		public UnityEvent<BoosterChannel> OnFinished;

		public UnityEvent<BoosterChannel> OnCancelOrFinish;

		public UnityEvent<BoosterChannel> OnResourceNotEnough;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
