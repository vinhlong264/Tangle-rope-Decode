using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Plinko
{
	public class PlinkoTutorialController : MonoBehaviour
	{
		[SerializeField]
		private GameObject tutorialMain;

		[SerializeField]
		private SpriteMask plinkoGameSpriteMask;

		[SerializeField]
		private SpriteMask plinkoGameSpriteMask2;

		[SerializeField]
		private List<GameObject> tutorialSteps;

		[SerializeField]
		private Button refreshTutorialXButton;

		[SerializeField]
		private Button refreshTutorialRefreshButton;

		[SerializeField]
		private Button[] skipStepButtons;

		[SerializeField]
		private GameObject refreshTutorialStep;

		private int stepIndex;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnRewardAreaTriggered(PlinkoEvents.OnRewardAreaTriggered p)
		{
		}

		private void OnRefreshTutorialXButtonClicked()
		{
		}

		private void OnRefreshTutorialRefreshButtonClicked()
		{
		}

		private void OnSkipStepClicked()
		{
		}

		private void OnRefreshButtonTutorialStarted(PlinkoEvents.OnRefreshButtonTutorialStarted p)
		{
		}

		private void OnPlinkoTutorialStarted(PlinkoEvents.OnPlinkoTutorialStarted p)
		{
		}

		private void ActivateTutorialStep(int stepIndex)
		{
		}

		private void CloseAllTutorialSteps()
		{
		}
	}
}
