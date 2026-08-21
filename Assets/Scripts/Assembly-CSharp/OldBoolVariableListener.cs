using Crescive.Atom;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

public class OldBoolVariableListener : MonoBehaviour
{
	[SerializeField]
	private AtomVariableType variableType;

	[SerializeField]
	private BoolVariable variable;

	[SerializeField]
	private BoolVariableInstancer variableInstancer;

	[SerializeField]
	private UnityEvent OnTrueOnAwake;

	[SerializeField]
	private UnityEvent OnFalseOnAwake;

	[SerializeField]
	private UnityEvent<bool> OnValueOnAwake;

	[SerializeField]
	private UnityEvent<bool> OnValueReverseOnAwake;

	[SerializeField]
	private UnityEvent OnTrueOnEnable;

	[SerializeField]
	private UnityEvent OnFalseOnEnable;

	[SerializeField]
	private UnityEvent<bool> OnValueOnEnable;

	[SerializeField]
	private UnityEvent<bool> OnValueReverseOnEnable;

	[SerializeField]
	private UnityEvent OnTrueOnStart;

	[SerializeField]
	private UnityEvent OnFalseOnStart;

	[SerializeField]
	private UnityEvent<bool> OnValueOnStart;

	[SerializeField]
	private UnityEvent<bool> OnValueReverseOnStart;

	[SerializeField]
	private UnityEvent OnChangeTrue;

	[SerializeField]
	private UnityEvent OnChangeFalse;

	[SerializeField]
	private UnityEvent<bool> OnChangeValue;

	[SerializeField]
	private UnityEvent<bool> OnChangeValueReverse;

	private bool ShowVariable => false;

	private bool ShowVariableInstancer => false;

	protected BoolVariable Variable => null;

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

	private void OnValueChanged(bool value)
	{
	}
}
