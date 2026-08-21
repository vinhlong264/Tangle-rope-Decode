using Crescive.HelperTypes;
using UnityEngine;

public class StringUnityEventCallbackDelegate : UnityEventCallbackDelegate<string>
{
	[SerializeField]
	private StringVariableReference variableReference;

	protected override string InvokeParameter => null;

	protected override bool HideStaticParameter => false;
}
