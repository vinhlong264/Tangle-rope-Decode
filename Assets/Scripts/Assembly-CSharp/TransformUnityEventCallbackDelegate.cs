using Crescive.TransformUtils;
using UnityEngine;

public class TransformUnityEventCallbackDelegate : UnityEventCallbackDelegate<Transform>
{
	[SerializeField]
	private TransformChannel transformChannel;

	protected override Transform InvokeParameter => null;

	protected override bool HideStaticParameter => false;
}
