using UnityEngine;

namespace Crescive.FeedbackPopUp
{
	[CreateAssetMenu(fileName = "FeedbackPopUpArgs", menuName = "Crescive/PopUp/FeedbackPopUp/FeedbackPopUpArgs")]
	public class FeedbackPopUpArgs : ScriptableObject
	{
		public bool isSuccess;

		public string message;

		public Color messageColor;
	}
}
