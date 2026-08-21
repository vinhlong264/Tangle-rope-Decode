using Crescive.CreatorMode;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ColorTargetDataController : MonoBehaviour
{
	[SerializeField]
	private TMP_InputField targetText;

	[SerializeField]
	private Image targetColorImage;

	[SerializeField]
	private Button clickButton;

	[SerializeField]
	private Button DestroyButton;

	public int TargetIndex;

	public int TargetCount;

	private ColorModeGoalController goalController;

	public void SetTarget(LevelCreatorSaveData.ColorTargetData targetData, ColorModeGoalController colorModeGoalController)
	{
	}

	public void DestroySelf()
	{
	}
}
