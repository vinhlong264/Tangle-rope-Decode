using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Progress
{
	public class ProgressEventsChannelListener : MonoBehaviour
	{
		[SerializeField]
		private ProgressEventsChannel channel;

		public UnityEvent OnStarted;

		public UnityEvent<float> OnProgress;

		public UnityEvent OnFinished;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
