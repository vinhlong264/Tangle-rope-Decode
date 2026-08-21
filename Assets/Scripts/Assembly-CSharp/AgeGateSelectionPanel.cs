using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgeGateSelectionPanel : AgeBaseGatePanel
{
	[SerializeField]
	private List<AgeSelection> selectionButtonList;

	[SerializeField]
	private Button continueButton;

	private int _current;

	private Action<int> _onSelected;

	public void Open(int answerValue, Action<int> onSelected)
	{
	}

	public void Close()
	{
	}

	private void UpdateTicks()
	{
	}

	private void UpdateContinueState()
	{
	}
}
