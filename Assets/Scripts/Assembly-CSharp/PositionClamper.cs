using UnityEngine;

public class PositionClamper : MonoBehaviour
{
	[SerializeField]
	private Vector3 minPos;

	[SerializeField]
	private Vector3 maxPos;

	[SerializeField]
	private Transform pivot;

	[SerializeField]
	private bool update;

	private void FixedUpdate()
	{
	}

	private void Clamp()
	{
	}

	public void SetUpdate(bool update)
	{
	}
}
