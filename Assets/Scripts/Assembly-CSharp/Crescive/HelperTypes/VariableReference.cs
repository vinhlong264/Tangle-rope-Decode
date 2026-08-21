using System;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms;
using UnityEngine;

namespace Crescive.HelperTypes
{
	[Serializable]
	public abstract class VariableReference<T, P, C, V, E1, E2, F, VI, AR, PV, SP, CSP> where P : struct, IPair<T> where C : AtomBaseVariable<T> where V : AtomVariable<T, P, E1, E2, F> where E1 : AtomEvent<T> where E2 : AtomEvent<P> where F : AtomFunction<T, T> where VI : AtomVariableInstancer<V, P, T, E1, E2, F> where AR : AtomReference<T, P, C, V, E1, E2, F, VI> where PV : PersistentVariable<T> where SP : ScriptableProperty<T> where CSP : ScriptableProperty<T>
	{
		[SerializeField]
		private VariableReferenceType variableReferenceType;

		[SerializeField]
		private AR atomReference;

		[SerializeField]
		private PV persistent;

		[SerializeField]
		private SP scriptableProperty;

		[SerializeField]
		private CSP conditionalScriptableProperty;

		private bool IsAtomReference => false;

		private bool IsPersistent => false;

		private bool IsScriptableProperty => false;

		private bool IsConditionalScriptableProperty => false;

		protected bool IsCustomType1 => false;

		public T Value => default(T);

		private T GetValue()
		{
			return default(T);
		}

		protected virtual T GetCustomType1Value()
		{
			return default(T);
		}

		public static implicit operator T(VariableReference<T, P, C, V, E1, E2, F, VI, AR, PV, SP, CSP> variableReference)
		{
			return default(T);
		}
	}
}
