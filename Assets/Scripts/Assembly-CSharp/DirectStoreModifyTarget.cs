using UnityEngine;

public abstract class DirectStoreModifyTarget : MonoBehaviour
{
	public bool onlyModifyOnce;

	protected bool modified;

	public void TryModify()
	{
	}

	protected abstract void ApplyModification();

	public int ModifyValue(int value, ModifyTargetValue<int> modifier)
	{
		return 0;
	}

	public float ModifyValue(float value, ModifyTargetValue<float> modifier)
	{
		return 0f;
	}
}
