using System.Collections.Generic;
using Crescive.TwistedTangle;
using UnityEngine;
using UnityEngine.UI;

public class StageIndicator : MonoBehaviour
{
	[SerializeField]
	private StageButtonController stageButton;

	[SerializeField]
	private Button addStageButton;

	private List<StageButtonController> _stageButtons;

	private LevelCreator _creator;

	private StageButtonController _currentActiveButton;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void CheckCurrentStageData()
	{
	}

	private void AddStage()
	{
	}

	private void OnLevelCreated()
	{
	}

	private void SetButton()
	{
	}

	private void ActivateStage(int obj)
	{
	}

	private void ResetButtons()
	{
	}
}
