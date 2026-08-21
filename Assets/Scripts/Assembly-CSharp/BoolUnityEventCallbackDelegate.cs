using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

public class BoolUnityEventCallbackDelegate : UnityEventCallbackDelegate<bool>
{
	[SerializeField]
	private BoolVariableReference variableReference;

	[SerializeField]
	private UnityEvent<bool> OnInvokedInverse;

	[SerializeField]
	private UnityEvent OnInvokedTrue;

	[SerializeField]
	private UnityEvent OnInvokedFalse;

	protected override bool InvokeParameter => false;

	protected override bool HideStaticParameter => false;

	protected override void InvokeInternal(bool value)
	{
	}
}
