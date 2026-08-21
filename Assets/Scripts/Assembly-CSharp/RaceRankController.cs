using System.Collections.Generic;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

public class RaceRankController : MonoBehaviour
{
	[SerializeField]
	private List<Sprite> rankSprites;

	[SerializeField]
	private Image badgeImage;

	[SerializeField]
	private TMP_Text badgeText;

	[SerializeField]
	private IntVariableInstancer rankValue;

	public void UpdateRank()
	{
	}
}
