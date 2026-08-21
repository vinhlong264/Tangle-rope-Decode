using Crescive.HelperTypes;
using UnityEngine;

public class FloatUnityEventCallbackDelegate : UnityEventCallbackDelegate<float>
{
	[SerializeField]
	private FloatVariableReference variableReference;

	protected override float InvokeParameter => 0f;

	protected override bool HideStaticParameter => false;
}
