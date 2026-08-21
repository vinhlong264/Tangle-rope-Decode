using PersistentSO;
using UnityEngine;

public class AgeGateController : AgeBaseGatePanel
{
	[SerializeField]
	private PersistentIntVariable setDate;

	[SerializeField]
	private PersistentIntVariable answer;

	private const int NoAnswer = 0;

	private const int Under18 = 1;

	private const int Under35 = 2;

	private const int Under50 = 3;

	private const int Over50 = 4;

	[SerializeField]
	private AgeGateSelectionPanel ageGateSelectionPanel;

	[SerializeField]
	private AgeGateUpdatePanel ageGateUpdatePanel;

	private bool IsGateEnabled => false;

	private void OnEnable()
	{
	}

	private void CheckAnswer(int answerValue)
	{
	}

	protected override void HidePanel()
	{
	}

	protected override void ShowPanel()
	{
	}

	private void OnSelected(int i)
	{
	}
}
