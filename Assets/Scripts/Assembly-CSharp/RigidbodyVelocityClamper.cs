using UnityEngine;

public class RigidbodyVelocityClamper : MonoBehaviour
{
	[SerializeField]
	private Vector3 minVelocity;

	[SerializeField]
	private Vector3 maxVelocity;

	[SerializeField]
	private Rigidbody body;

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
