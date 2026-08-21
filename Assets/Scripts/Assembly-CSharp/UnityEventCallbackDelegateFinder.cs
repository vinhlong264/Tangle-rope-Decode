using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

[DefaultExecutionOrder(-10000)]
public class UnityEventCallbackDelegateFinder : MonoBehaviour
{
	[SerializeField]
	private GameObject target;

	[SerializeField]
	private StringReference delegateId;

	[SerializeField]
	private bool includeInactive;

	public UnityEvent<BaseUnityEventCallbackDelegate> OnFindCallbackDelegate;

	public UnityEvent<List<BaseUnityEventCallbackDelegate>> OnFindAllCallbackDelegates;

	private void Awake()
	{
	}
}
