using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LiveObstaclePanel : MonoBehaviour
{
	[SerializeField]
	private TMP_Text testText;

	[SerializeField]
	private Button addButton;

	[SerializeField]
	private LiveObstacleUi liveObstacleUiPrefab;

	[SerializeField]
	private Transform liveObstacleContainer;

	private List<LiveObstacleUi> liveObstacleUis;

	private void OnEnable()
	{
	}

	private void CheckLiveObstacles()
	{
	}

	private void OnDisable()
	{
	}

	private void ClearLiveObstacleUi()
	{
	}

	private void OnObstacleCreateButtonClicked()
	{
	}

	private void CreateLiveObstacleUi(LiveObstacleEntity i)
	{
	}
}
