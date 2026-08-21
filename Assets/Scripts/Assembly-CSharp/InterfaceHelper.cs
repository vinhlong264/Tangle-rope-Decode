using System;
using UnityEngine;

[Serializable]
public class InterfaceHelper<T>
{
	[SerializeField]
	private UnityEngine.Object _Target;

	public T Value
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}
}
