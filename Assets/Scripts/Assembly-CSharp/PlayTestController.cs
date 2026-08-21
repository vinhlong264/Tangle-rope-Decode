using System;
using Crescive.CreatorMode;
using Crescive.TwistedTangle;
using CresciveCore;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

public class PlayTestController : MonoBehaviour
{
	[SerializeField]
	private LevelSystem levelSystem;

	[SerializeField]
	private LevelCreatorChannel levelCreatorChannel;

	[SerializeField]
	private VoidEvent loadLevelEvent;

	[SerializeField]
	private VoidEvent resetEvent;

	[SerializeField]
	private Button playTestButton;

	[SerializeField]
	private GameObject mapChecker;

	[SerializeField]
	private TimeLimitController timeLimitController;

	[SerializeField]
	private IntVariable timeLimit;

	[SerializeField]
	private TMP_Text leftTimeText;

	[SerializeField]
	private TMP_Text spentTimeText;

	[SerializeField]
	private UiLogger logger;

	private int _totalTime;

	private int _remainingTime;

	private int _spentTime;

	private bool _isPlayingTest;

	private bool _isFailedTest;

	private DateTime _failedTime;

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void SetMapCheckerActive(bool isActive)
	{
	}

	private void OnPlayTestButtonClicked()
	{
	}

	private void LevelLoadingEnded()
	{
	}

	private void OnLevelCreatedCallback()
	{
	}

	private void SetTestState(bool isPlaying)
	{
	}

	private void StopTest()
	{
	}

	public void SuccessTest()
	{
	}

	public void FailTest()
	{
	}
}
