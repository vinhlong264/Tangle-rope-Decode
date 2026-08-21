using Crescive.TwistedTangle;
using UnityEngine;
using UnityEngine.Events;

public class RopeSelecter : MonoBehaviour
{
	[SerializeField]
	private RopeChannel selectedRope;

	[SerializeField]
	private UnityEvent<RopeEntity> OnRopeAssigned;

	private bool shouldSelect;

	public void SetShouldSelect(bool shouldSelect)
	{
	}

	public void SetRope(RopeEntity rope)
	{
	}
}
