using Crescive.Navigation;
using Crescive.UI;
using UnityEngine;

namespace Crescive.Boosters
{
	public class BoosterUseTutorialPopupController : MonoBehaviour
	{
		[SerializeField]
		private Navigatable navigatable;

		[SerializeField]
		private BoosterSystem boosterSystem;

		[SerializeField]
		private BoosterButtonsControllerChannel buttonsControllerChannel;

		[Space]
		[SerializeField]
		private RectTransform tutorialFocus;

		[SerializeField]
		private UIEventTriggerDelegate eventTriggerDelegate;

		public void OnShowArgs(BoosterChannel boosterChannel)
		{
		}

		public void OnAnyBoosterRequested()
		{
		}
	}
}
