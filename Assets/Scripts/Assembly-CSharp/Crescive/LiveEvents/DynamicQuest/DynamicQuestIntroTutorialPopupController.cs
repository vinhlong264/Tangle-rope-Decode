using Crescive.Navigation;
using Crescive.UI;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestIntroTutorialPopupController : MonoBehaviour
	{
		[SerializeField]
		private Navigatable navigatable;

		[SerializeField]
		private DynamicQuestSystem dynamicQuestSystem;

		[SerializeField]
		private DynamicQuestProgressBarChannel progressBarChannel;

		[SerializeField]
		private RectTransform clickRewardTutorialPivot;

		[SerializeField]
		private UIEventTriggerDelegate eventTriggerDelegate;

		private void OnRewardClicked()
		{
		}

		public void OnShow()
		{
		}
	}
}
