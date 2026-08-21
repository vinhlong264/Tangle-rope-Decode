using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventCallbackDelegatesListener : MonoBehaviour
{
	[SerializeField]
	private List<BaseUnityEventCallbackDelegate> callbackDelegates;

	public UnityEvent OnInvoked;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetCallbackDelegates(List<BaseUnityEventCallbackDelegate> newCallbackDelegates)
	{
	}
}
