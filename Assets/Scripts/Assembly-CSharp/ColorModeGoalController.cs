using System.Collections.Generic;
using Crescive.CreatorMode;
using UnityEngine;
using UnityEngine.UI;

public class ColorModeGoalController : MonoBehaviour
{
	[SerializeField]
	private GameObject targetPanel;

	[SerializeField]
	private Button closeButton;

	[SerializeField]
	private Button addButton;

	[SerializeField]
	private LevelCreatorChannel levelCreatorChannel;

	[SerializeField]
	private Transform targetPanelTransform;

	[SerializeField]
	private ColorTargetDataController colorTargetData;

	private List<LevelCreatorSaveData.ColorTargetData> colorTargetDatas;

	private List<ColorTargetDataController> targetDataControllers;

	public void OpenTargetPanel()
	{
	}

	private void CloseTargetPanel()
	{
	}

	private void AddNewTarget()
	{
	}

	public void RemoveTarget(ColorTargetDataController targetDataController)
	{
	}
}
