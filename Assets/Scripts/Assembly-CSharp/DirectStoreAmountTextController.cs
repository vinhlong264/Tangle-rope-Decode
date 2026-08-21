using TMPro;
using UnityEngine;

public class DirectStoreAmountTextController : MonoBehaviour
{
	[SerializeField]
	private TMP_Text referenceText;

	[SerializeField]
	private TMP_Text targetText;

	[SerializeField]
	private CanvasGroup referenceCanvasGroup;

	[SerializeField]
	private CanvasGroup targetCanvasGroup;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void TMPTextUpdated(TMP_TextInfo obj)
	{
	}

	private void UpdateTextCheck()
	{
	}

	private void UpdateText(bool useDirectStoreFlow)
	{
	}

	public void UpdateUI(bool useDirectStoreFlow)
	{
	}
}
