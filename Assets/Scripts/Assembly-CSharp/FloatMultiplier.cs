using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

public class FloatMultiplier : MonoBehaviour
{
	[SerializeField]
	private FloatReference multiplier;

	public UnityEvent<float> OnMultiply;

	public UnityEvent<int> OnMultiplyRoundToIntInt;

	public void Multiply(float value)
	{
	}
}
