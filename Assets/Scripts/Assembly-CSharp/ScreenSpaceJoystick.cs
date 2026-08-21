using NaughtyAttributes;
using UnityEngine;

public class ScreenSpaceJoystick : MonoBehaviour
{
	[SerializeField]
	[Range(1E-05f, 1f)]
	private float screenThresholdRatio;

	[SerializeField]
	[Range(0f, 1f)]
	private float minThreshold;

	[SerializeField]
	private bool useUnscaledDeltaTime;

	[SerializeField]
	private bool useSmoothInput;

	[ShowIf("useSmoothInput")]
	[SerializeField]
	private float xLerpSpeed;

	[SerializeField]
	[ShowIf("useSmoothInput")]
	private float yLerpSpeed;

	private float _horizontal;

	private float _vertical;

	private float _screenXSize;

	private float _screenYSize;

	private bool _dragging;

	private float _startX;

	private float _startY;

	public bool debug;

	private float DeltaTime => 0f;

	public float Horizontal => 0f;

	public float Vertical => 0f;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private float ScaleInActualRatio(float value)
	{
		return 0f;
	}

	private void UpdateStartPositionX()
	{
	}

	private void UpdateStartPositionY()
	{
	}

	private void Setup()
	{
	}

	private void UpdateAllData()
	{
	}

	private void HandleMouseDown()
	{
	}

	private void HandleMouseUp()
	{
	}

	private void HandleMouseDrag()
	{
	}
}
