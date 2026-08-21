using System.Collections.Generic;
using Crescive.TwistedTangle;
using UnityEngine;
using UnityEngine.UI;

public class EditorColorModeController : MonoBehaviour
{
	private enum EditorPaintMode
	{
		None = 0,
		Cycle = 1,
		Paint = 2
	}

	[SerializeField]
	[Header("UI References")]
	private GameObject popupPanel;

	[SerializeField]
	[Header("UI References")]
	private ColorModeGoalController targetPanel;

	[SerializeField]
	private Button togglePopupButton;

	[SerializeField]
	private Button colorModeButton;

	[SerializeField]
	private Button clearAllButton;

	[SerializeField]
	private Button paintToggleButton;

	[SerializeField]
	private Button paintAllButton;

	[SerializeField]
	private Button closeButton;

	[SerializeField]
	private Button colorButton;

	[SerializeField]
	private Button goalButton;

	[Header("Data References")]
	[SerializeField]
	private PinSlotsChannel pinSlotsChannel;

	private EditorPaintMode currentMode;

	private List<Color> colorList;

	private Color selectedColor;

	private int selectedColorIndex;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OpenTargetPanel()
	{
	}

	private void TogglePopup()
	{
	}

	private void ToggleCycleMode()
	{
	}

	private void TogglePaintMode()
	{
	}

	private void UpdateButtonTexts()
	{
	}

	private void CycleColor()
	{
	}

	private void ClearAllColors()
	{
	}

	private void PaintAllPins()
	{
	}

	private void Update()
	{
	}

	private void UpdateLevel()
	{
	}
}
