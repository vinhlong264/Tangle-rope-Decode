using Crescive.Navigation;
using UnityEngine;
using UnityEngine.UI;

namespace DynamicQuestTime
{
	public class DynamicQuestTimeIntroTutorial : MonoBehaviour
	{
		[SerializeField]
		private GameObject main;

		[SerializeField]
		private Button rewardButton;

		[SerializeField]
		private Navigatable navigatable;

		[SerializeField]
		private RectTransform clickRewardTutorialPivot;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDynamicQuestTimeCloseTutorial(DynamicQuestTimeEvents.OnDynamicQuestTimeCloseTutorial p)
		{
		}

		private void OnDynamicQuestTimeProgressBarRewardPosition(DynamicQuestTimeEvents.OnDynamicQuestTimeProgressBarRewardPosition p)
		{
		}

		private void OnDynamicQuestTimeTutorialStarted(DynamicQuestTimeEvents.OnDynamicQuestTimeTutorialStarted p)
		{
		}

		private void OnRewardButtonClicked()
		{
		}

		public void OpenUI()
		{
		}

		public void CloseUI()
		{
		}
	}
}
