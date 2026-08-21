using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class PinMergeDelegate : MonoBehaviour
	{
		public UnityEvent<bool> OnMergeStarted;

		public UnityEvent<bool> OnJumpAnimCompleted;

		public UnityEvent<bool> OnMergeCompleted;

		public void TriggerMergeStarted(bool isSource)
		{
		}

		public void TriggerJumpAnimCompleted(bool isSource)
		{
		}

		public void TriggerMergeCompleted(bool isSource)
		{
		}
	}
}
