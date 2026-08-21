using UnityEngine;
using UnityEngine.Events;

namespace Crescive.FeedbackPopUp
{
	[CreateAssetMenu(fileName = "FeedbackPopUpEvents", menuName = "Crescive/PopUp/FeedbackPopUp/FeedbackPopUpEvents")]
	public class FeedbackPopUpEvents : ScriptableObject
	{
		public UnityEvent<FeedbackPopUpArgs> OnOpenRequested;

		public void Trigger(FeedbackPopUpArgs args)
		{
		}
	}
}
