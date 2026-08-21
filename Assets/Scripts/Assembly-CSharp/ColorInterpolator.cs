using UnityEngine;
using UnityEngine.Events;

public class ColorInterpolator : MonoBehaviour
{
	[SerializeField]
	private Color targetColor;

	[Range(0f, 1f)]
	[SerializeField]
	private float percent;

	public UnityEvent<Color> OnColorChange;

	public void InterpolateColor(Color startColor)
	{
	}
}
