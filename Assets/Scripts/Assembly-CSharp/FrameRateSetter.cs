using UnityEngine;

public class FrameRateSetter : MonoBehaviour
{
	[Range(0f, 144f)]
	[SerializeField]
	private int targetFrameRate;

	[SerializeField]
	private bool setOnAwake;

	private void Awake()
	{
	}

	private void SetFrameRate()
	{
	}

	public void SetFrameRate(int frameRate)
	{
	}
}
