using UnityEngine;
using UnityEngine.Events;

namespace Crescive.FeedbackPopUp
{
	public class FeedbackPopUpEventsListener : MonoBehaviour
	{
		[SerializeField]
		private FeedbackPopUpEvents events;

		public UnityEvent<FeedbackPopUpArgs> OnOpenRequested;

		public UnityEvent<bool> OnOpenRequestedIsSuccess;

		public UnityEvent<bool> OnOpenRequestedIsFail;

		public UnityEvent OnOpenRequestedSuccess;

		public UnityEvent OnOpenRequestedFail;

		public UnityEvent<string> OnOpenRequestedMessage;

		public UnityEvent<Color> OnOpenRequestedMessageColor;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void TriggerEvents(FeedbackPopUpArgs args)
		{
		}
	}
}
