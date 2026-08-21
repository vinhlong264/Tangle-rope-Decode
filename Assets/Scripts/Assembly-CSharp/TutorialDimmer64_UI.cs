using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class TutorialDimmer64_UI : MonoBehaviour, ICanvasRaycastFilter
{
	public List<Transform> targets;

	public float uiPaddingPx;

	public float worldRadiusPx;

	public float featherPx;

	private Image img;

	private Canvas canvas;

	private Camera uiCam;

	private Material mat;

	private readonly Vector4[] holes;

	private readonly Vector2[] centersPx;

	private readonly float[] radiiPx;

	private int count;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCam)
	{
		return false;
	}
}
