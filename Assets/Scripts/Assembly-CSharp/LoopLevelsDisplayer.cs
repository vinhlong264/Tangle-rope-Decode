using System.Collections.Generic;
using PersistentSO;
using TMPro;
using UnityEngine;

public class LoopLevelsDisplayer : MonoBehaviour
{
	[SerializeField]
	private PersistentIntListVariable loopLevels;

	[SerializeField]
	private TextMeshProUGUI displayText;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void SetText(List<int> loopLevelsList)
	{
	}
}
