using UnityEngine;
using UnityEngine.Events;

public class UnityEventCallbackDelegateListener : MonoBehaviour
{
	[SerializeField]
	private BaseUnityEventCallbackDelegate callbackDelegate;

	public UnityEvent OnInvoked;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetCallbackDelegate(BaseUnityEventCallbackDelegate newCallbackDelegate)
	{
	}
}
