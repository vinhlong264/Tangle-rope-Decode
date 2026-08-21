using Crescive.HelperTypes;
using UnityEngine;

public class Vector3UnityEventCallbackDelegate : UnityEventCallbackDelegate<Vector3>
{
	[SerializeField]
	private Vector3VariableReference variableReference;

	protected override Vector3 InvokeParameter => default(Vector3);

	protected override bool HideStaticParameter => false;
}
