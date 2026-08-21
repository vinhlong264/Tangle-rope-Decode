using Crescive.HelperTypes;
using UnityEngine;

public class Vector2UnityEventCallbackDelegate : UnityEventCallbackDelegate<Vector2>
{
	[SerializeField]
	private Vector2VariableReference variableReference;

	protected override Vector2 InvokeParameter => default(Vector2);

	protected override bool HideStaticParameter => false;
}
