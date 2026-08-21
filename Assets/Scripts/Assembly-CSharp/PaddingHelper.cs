using DG.Tweening;
using UnityEngine;
using Utility.SLayout;

public class PaddingHelper : MonoBehaviour
{
	[SerializeField]
	private SLayoutGroup layoutGroup;

	[SerializeField]
	private RectOffset isAnyEnabledOffset;

	[SerializeField]
	private RectOffset allDisabledOffset;

	[SerializeField]
	private GameObject[] checkGameobjects;

	[SerializeField]
	private float isAnyEnabledSpacing;

	[SerializeField]
	private float allDisabledSpacing;

	private Tween onEnableTween;

	private void OnEnable()
	{
	}
}
