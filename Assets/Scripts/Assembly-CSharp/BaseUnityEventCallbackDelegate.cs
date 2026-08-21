using Crescive.HelperTypes;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

public abstract class BaseUnityEventCallbackDelegate : MonoBehaviour
{
	[Header("Identifier")]
	[SerializeField]
	private StringReference delegateId;

	[Header("Condition")]
	[SerializeField]
	protected bool hasCondition;

	[SerializeField]
	protected ConditionSource conditionSource;

	public string DelegateId => null;

	public abstract UnityEvent OnBaseInvoked { get; }

	protected bool HasConditionAndNotMet()
	{
		return false;
	}
}
