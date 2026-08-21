using System.Collections.Generic;
using Shapes;
using UnityEngine;

public class ShapesColorSetter : MonoBehaviour
{
	[Header("Settings")]
	[SerializeField]
	private List<Color> colors;

	private ShapeRenderer shapeRenderer;

	private void Awake()
	{
	}

	public void SetColorWithIndex(int index)
	{
	}
}
