using System;
using UnityEngine;

public class RequireInterfaceAttribute : PropertyAttribute
{
	public Type requiredType { get; private set; }

	public RequireInterfaceAttribute(Type type)
	{
	}
}
