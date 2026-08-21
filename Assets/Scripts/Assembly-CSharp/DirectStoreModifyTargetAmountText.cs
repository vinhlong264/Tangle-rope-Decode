using TMPro;
using UnityEngine;

public class DirectStoreModifyTargetAmountText : DirectStoreModifyTarget
{
	[SerializeField]
	private TMP_Text referenceText;

	[SerializeField]
	private TMP_Text targetText;

	[SerializeField]
	private CanvasGroup referenceCanvasGroup;

	[SerializeField]
	private CanvasGroup targetCanvasGroup;

	protected override void ApplyModification()
	{
	}
}
