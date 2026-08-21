using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Atom.VariableListener
{
	public abstract class AtomVariableListener<V, VI, T, P, E1, E2, F> : MonoBehaviour where V : AtomVariable<T, P, E1, E2, F> where VI : AtomVariableInstancer<V, P, T, E1, E2, F> where P : struct, IPair<T> where E1 : AtomEvent<T> where E2 : AtomEvent<P> where F : AtomFunction<T, T>
	{
		[SerializeField]
		private AtomVariableType variableType;

		[SerializeField]
		private V variable;

		[SerializeField]
		private VI variableInstancer;

		[SerializeField]
		protected bool triggerChangedOnAwake;

		[SerializeField]
		protected bool triggerChangedOnEnable;

		[SerializeField]
		protected bool triggerChangedOnStart;

		[SerializeField]
		protected bool dontTriggerChanged;

		public UnityEvent<T> OnValueChanged;

		public UnityEvent<T, T> OnValueChangedHistory;

		private bool ShowVariable => false;

		private bool ShowVariableInstancer => false;

		protected V Variable => null;

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

		private void OnValueChangedCallback(T value)
		{
		}

		private void OnValueChangedWithHistoryCallback(P pair)
		{
		}

		protected virtual void OnValueChangedCallbackInternal(T value)
		{
		}

		protected virtual void OnValueChangedWithHistoryCallbackInternal(P pair)
		{
		}

		public void TriggerValueChangedEventWithCurrentValue()
		{
		}
	}
}
