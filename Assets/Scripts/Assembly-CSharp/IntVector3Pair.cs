using System;
using UnityEngine;

[Serializable]
public struct IntVector3Pair
{
	public int IntValue;

	public Vector3 Vector3Value;

	public IntVector3Pair(int intValue, Vector3 vector3Value)
	{
		IntValue = 0;
		Vector3Value = default(Vector3);
	}
}
