using System;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.HelperTypes
{
	[Serializable]
	public abstract class SettableVariableReference<T, P, C, V, E1, E2, F, VI, PV, SSP> where P : struct, IPair<T> where C : AtomBaseVariable<T> where V : AtomVariable<T, P, E1, E2, F> where E1 : AtomEvent<T> where E2 : AtomEvent<P> where F : AtomFunction<T, T> where VI : AtomVariableInstancer<V, P, T, E1, E2, F> where PV : PersistentVariable<T> where SSP : SettableScriptableProperty<T>
	{
		[SerializeField]
		private SettableVariableReferenceType settableVariableReferenceType;

		[SerializeField]
		private V atomVariable;

		[SerializeField]
		private VI atomVariableInstancer;

		[SerializeField]
		private PV persistent;

		[SerializeField]
		private SSP settableScriptableProperty;

		private bool IsAtomVariable => false;

		private bool IsAtomVariableInstancer => false;

		private bool IsPersistent => false;

		private bool IsSettableScriptableProperty => false;

		public T Value
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		private T GetValue()
		{
			return default(T);
		}

		private void SetValue(T value)
		{
		}

		public void Subscribe(Action<T> action, UnityAction<T> unityAction)
		{
		}

		public void Unsubscribe(Action<T> action, UnityAction<T> unityAction)
		{
		}

		public static implicit operator T(SettableVariableReference<T, P, C, V, E1, E2, F, VI, PV, SSP> settableVariableReference)
		{
			return default(T);
		}
	}
}
