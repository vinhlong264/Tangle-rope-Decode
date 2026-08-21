using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextMeshColorSetter : MonoBehaviour
{
	[Header("References")]
	[SerializeField]
	private TMP_Text tmp;

	[ColorUsage(true)]
	[SerializeField]
	[Header("Settings")]
	private List<Color> colors;

	public void SetColorWithIndex(int index)
	{
	}
}
