using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

public class IntMultiplier : MonoBehaviour
{
	[SerializeField]
	private IntReference multiplier;

	public UnityEvent<int> OnMultiply;

	public UnityEvent<float> OnMultiplyAsFloat;

	public void Multiply(int value)
	{
	}
}
