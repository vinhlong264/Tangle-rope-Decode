using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	[DefaultExecutionOrder(1)]
	public class TimeFreezeFadeFx : MonoBehaviour
	{
		[SerializeField]
		private TimeFreezeAnimatorChannel timeFreezeAnimatorChannel;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[Space]
		public UnityEvent OnActivated;

		public UnityEvent OnDeactivated;

		public CanvasGroup CanvasGroup => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}
	}
}
