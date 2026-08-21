using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class NumberInterpolator : MonoBehaviour
{
	[SerializeField]
	private float lerpSpeed;

	[SerializeField]
	private FloatReference actualValue;

	[SerializeField]
	private FloatReference currentValue;

	private void Update()
	{
	}

	private void LerpNumber()
	{
	}

	public void UpdateNumber(float value)
	{
	}

	public void UpdateNumber(FloatVariable variable)
	{
	}

	public void UpdateNumber(PersistentFloatVariable variable)
	{
	}

	public void UpdateNumber(FloatScriptableProperty property)
	{
	}

	public void UpdateNumber(int value)
	{
	}

	public void UpdateNumber(IntVariable variable)
	{
	}

	public void UpdateNumber(PersistentIntVariable variable)
	{
	}

	public void UpdateNumber(IntScriptableProperty property)
	{
	}
}
