using System;
using Crescive.HelperTypes;
using PersistentSO;
using UnityAtoms;
using UnityEngine;

namespace Crescive.Scriptables
{
	[Serializable]
	public abstract class ConditionVariableReferencePair<T, P, C, V, E1, E2, F, VI, AR, PV, SP, CSP, VR> where P : struct, IPair<T> where C : AtomBaseVariable<T> where V : AtomVariable<T, P, E1, E2, F> where E1 : AtomEvent<T> where E2 : AtomEvent<P> where F : AtomFunction<T, T> where VI : AtomVariableInstancer<V, P, T, E1, E2, F> where AR : AtomReference<T, P, C, V, E1, E2, F, VI> where PV : PersistentVariable<T> where SP : ScriptableProperty<T> where CSP : ScriptableProperty<T> where VR : VariableReference<T, P, C, V, E1, E2, F, VI, AR, PV, SP, CSP>
	{
		[SerializeField]
		private ConditionSource conditionSource;

		[SerializeField]
		private VR value;

		public bool TryGetValue(out T val)
		{
			val = default(T);
			return false;
		}
	}
}
