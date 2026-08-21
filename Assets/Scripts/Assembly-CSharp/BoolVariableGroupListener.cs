using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

public class BoolVariableGroupListener : MonoBehaviour
{
	[Header("References")]
	[SerializeField]
	private List<BoolVariable> variables;

	[SerializeField]
	private UnityEvent OnAllTrueOnAwake;

	[SerializeField]
	private UnityEvent OnAllFalseOnAwake;

	[SerializeField]
	private UnityEvent OnMixedOnAwake;

	[SerializeField]
	private UnityEvent OnAllTrueOnStart;

	[SerializeField]
	private UnityEvent OnAllFalseOnStart;

	[SerializeField]
	private UnityEvent OnMixedOnStart;

	[SerializeField]
	private UnityEvent OnAllTrueOnChanged;

	[SerializeField]
	private UnityEvent OnAllFalseOnChanged;

	[SerializeField]
	private UnityEvent OnMixedOnChanged;

	private bool IsAllTrue => false;

	private bool IsAllFalse => false;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void OnValueChanged(bool _)
	{
	}
}
