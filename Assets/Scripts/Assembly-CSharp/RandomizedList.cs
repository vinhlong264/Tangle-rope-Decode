using System.Collections.Generic;
using UnityEngine;

public abstract class RandomizedList<T> : ScriptableObject, IResettableObject
{
	[SerializeField]
	private List<T> list;

	private List<T> randomizedList;

	private int currentIndex;

	public void ResetData()
	{
	}

	public List<T> GetShuffledListCopy()
	{
		return null;
	}

	public T GetNext()
	{
		return default(T);
	}
}
