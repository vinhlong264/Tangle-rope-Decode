using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

public class UIImageSetter : MonoBehaviour
{
	[Header("References")]
	[SerializeField]
	private Image image;

	[SerializeField]
	[Header("Settings")]
	private List<Color> colors;

	[SerializeField]
	private List<Sprite> sprites;

	public void SetColorWithIndex(int index)
	{
	}

	public void SetSpriteWithIndex(int index)
	{
	}

	public void SetColorWithNumber(int number)
	{
	}

	public void SetSpriteWithNumber(int number)
	{
	}

	public void SetSpriteWithNumber(IntVariable number)
	{
	}

	public void SetSpriteWithNumber(IntVariableInstancer number)
	{
	}
}
