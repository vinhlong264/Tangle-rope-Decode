using Systems.ColorGameMode;
using UnityEngine;

public class ThirdLevelTutorialUiController : MonoBehaviour
{
	[SerializeField]
	private GameObject goalUi;

	[SerializeField]
	private GameObject timerUi;

	[SerializeField]
	private GoalUI goalUI;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnOverrideSortingGoal(TutorialEvents.OverrideSortingGoal obj)
	{
	}

	private void OnOverrideSortingGoalsAndTimer(TutorialEvents.OverrideSortingGoalsAndTimer obj)
	{
	}

	private void OverrideSortGoalAndTimer(int sort, bool isAdd)
	{
	}

	private void OverrideGoals(int sort, bool isAdd)
	{
	}

	private void OverrideGoal(int sort, bool isAdd)
	{
	}

	private void OverrideTimer(int sort, bool isAdd)
	{
	}
}
