using UnityEngine;
using UnityEngine.UI;

public class DirectStoreModifyTargetLayoutGroupPadding : DirectStoreModifyTarget
{
	[SerializeField]
	private LayoutGroup targetLayoutGroup;

	[SerializeField]
	private RectOffset layoutGroupPadding;

	protected override void ApplyModification()
	{
	}
}
