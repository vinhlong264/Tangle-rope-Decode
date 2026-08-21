using UnityEngine;

[RequireComponent(typeof(RectTransform))]
[ExecuteAlways]
public class DynamicCenteredGrid : MonoBehaviour
{
	public int maxColumns;

	public Vector2 spacing;

	public RectOffset padding;

	private RectTransform rectTransform;

	private void OnEnable()
	{
	}

	private void OnRectTransformDimensionsChange()
	{
	}

	public void UpdateLayout()
	{
	}
}
