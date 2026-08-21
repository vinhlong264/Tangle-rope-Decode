using UnityEngine;
using Utility.SLayout;

public class DirectStoreModifyTargetSLayoutGroupPadding : DirectStoreModifyTarget
{
	[SerializeField]
	private SLayoutGroup targetLayoutGroup;

	[SerializeField]
	private RectOffset layoutGroupPadding;

	protected override void ApplyModification()
	{
	}
}
