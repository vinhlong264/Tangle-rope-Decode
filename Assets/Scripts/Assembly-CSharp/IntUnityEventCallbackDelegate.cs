using Crescive.HelperTypes;
using UnityEngine;

public class IntUnityEventCallbackDelegate : UnityEventCallbackDelegate<int>
{
	[SerializeField]
	private IntVariableReference variableReference;

	protected override int InvokeParameter => 0;

	protected override bool HideStaticParameter => false;
}
