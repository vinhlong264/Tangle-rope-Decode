using System;

[Serializable]
public struct WeightedRandomListData<T>
{
	public int weight;

	public T data;
}
