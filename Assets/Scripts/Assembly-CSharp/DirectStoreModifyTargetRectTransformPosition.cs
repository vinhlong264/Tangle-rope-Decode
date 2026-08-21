using UnityEngine;

public class DirectStoreModifyTargetRectTransformPosition : DirectStoreModifyTarget
{
	[SerializeField]
	private RectTransform targetRectTransform;

	[SerializeField]
	private ModifyTargetFloat posY;

	[SerializeField]
	private ModifyTargetFloat posX;

	protected override void ApplyModification()
	{
	}
}
