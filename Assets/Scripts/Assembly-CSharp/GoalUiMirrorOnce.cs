using System.Collections.Generic;
using Systems.ColorGameMode;
using UnityEngine;

public class GoalUiMirrorOnce : MonoBehaviour
{
	[Header("Mirror Cells (sadece görsel)")]
	[SerializeField]
	private GoalTargetObjectUI[] mirrorCells;

	[SerializeField]
	private RectTransform[] mirrorRects;

	[SerializeField]
	private RectTransform layoutGroup1;

	[SerializeField]
	private RectTransform layoutGroup2;

	[SerializeField]
	[Header("Cell Sizes")]
	private Vector2 sizeFor1or2;

	[SerializeField]
	private Vector2 sizeFor3;

	[SerializeField]
	private Vector2 sizeDefault;

	private void OnEnable()
	{
	}

	[ContextMenu("Render From GoalUI Now")]
	public void RenderOnceFromGoalUI()
	{
	}

	private void RenderSnapshot(List<GoalUI.TargetSnapshot> snap)
	{
	}

	private bool InRange(int i)
	{
		return false;
	}
}
