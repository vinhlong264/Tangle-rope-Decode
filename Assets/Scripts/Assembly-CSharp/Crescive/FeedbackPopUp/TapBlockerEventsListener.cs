using UnityEngine;
using UnityEngine.Events;

namespace Crescive.FeedbackPopUp
{
	public class TapBlockerEventsListener : MonoBehaviour
	{
		[SerializeField]
		private TapBlockerEvents events;

		public UnityEvent OnBlock;

		public UnityEvent OnUnblock;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnBlockCallback()
		{
		}

		private void OnUnblockCallback()
		{
		}
	}
}
