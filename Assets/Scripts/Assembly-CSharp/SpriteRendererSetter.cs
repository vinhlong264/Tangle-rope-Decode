using System.Collections.Generic;
using UnityEngine;

public class SpriteRendererSetter : MonoBehaviour
{
	[SerializeField]
	[Header("Settings")]
	private List<Color> colors;

	[SerializeField]
	private List<Sprite> sprites;

	private SpriteRenderer spriteRenderer;

	private void Awake()
	{
	}

	public void SetColorWithIndex(int index)
	{
	}

	public void SetSpriteWithIndex(int index)
	{
	}
}
