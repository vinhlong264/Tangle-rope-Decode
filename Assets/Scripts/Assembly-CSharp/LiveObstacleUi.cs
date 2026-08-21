using System;
using System.Collections.Generic;
using Crescive.ColorUtils;
using Crescive.CreatorMode;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LiveObstacleUi : MonoBehaviour
{
	[SerializeField]
	private Button deleteButton;

	[SerializeField]
	private Button rightButton;

	[SerializeField]
	private Button leftButton;

	[SerializeField]
	private Button upButton;

	[SerializeField]
	private Button downButton;

	[SerializeField]
	private Button rotateRightButton;

	[SerializeField]
	private Button rotateLeftButton;

	[SerializeField]
	private Button colorButton;

	[SerializeField]
	private TMP_Dropdown obstacleTypeDropdown;

	[SerializeField]
	private TMP_Dropdown obstacleSubTypeDropdown;

	[SerializeField]
	private TMP_InputField hpInputField;

	[SerializeField]
	private ColorListData defaultColorListData;

	private readonly List<ObstacleSubType> _currentSubTypeList;

	private int _defaultColorIndex;

	private static readonly Dictionary<ObstacleType, Dictionary<ObstacleSubType, string>> SubTypeNameMap;

	private LiveObstacleEntity _liveObstacleEntity;

	private LiveObstacleData CurrentData => null;

	public void Initialize(LiveObstacleEntity index)
	{
	}

	private void InitializeDropdowns()
	{
	}

	private void InitializeUIValues()
	{
	}

	private void RegisterUIListeners()
	{
	}

	private void UpdateSubTypeDropdown(ObstacleType type)
	{
	}

	private void OnObstacleTypeChanged(int selectedIndex)
	{
	}

	private void OnObstacleSubTypeChanged(int selectedIndex)
	{
	}

	private void OnHpInputFieldEndEdit(string input)
	{
	}

	private void OnColorButtonClicked()
	{
	}

	private void OnRotateButtonClicked(bool isLeft)
	{
	}

	private void MoveObstacle(Vector3 direction)
	{
	}

	private void OnDeleteButtonClicked()
	{
	}

	private void SetColor()
	{
	}

	private void SetDropdownValue(TMP_Dropdown dropdown, string value)
	{
	}

	private void ApplyDataUpdate(Action<LiveObstacleData> update)
	{
	}

	private void OnDestroy()
	{
	}
}
