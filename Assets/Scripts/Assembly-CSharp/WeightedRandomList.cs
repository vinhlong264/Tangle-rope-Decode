using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class WeightedRandomList<T>
{
	[SerializeField]
	private List<WeightedRandomListData<T>> list;

	public int Count => 0;

	public List<WeightedRandomListData<T>> List => null;

	public void Add(WeightedRandomListData<T> item)
	{
	}

	public T GetRandom()
	{
		return default(T);
	}

	public WeightedRandomList<T> Where(Func<WeightedRandomListData<T>, bool> predicate)
	{
		return null;
	}
}
