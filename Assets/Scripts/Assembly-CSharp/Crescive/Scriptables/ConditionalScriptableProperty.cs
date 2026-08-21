using System.Collections.Generic;
using Crescive.HelperTypes;
using PersistentSO;
using UnityAtoms;
using UnityEngine;

namespace Crescive.Scriptables
{
	public abstract class ConditionalScriptableProperty<T, P, C, V, E1, E2, F, VI, AR, PV, SP, CSP, VR, CVRP> : ScriptableProperty<T> where P : struct, IPair<T> where C : AtomBaseVariable<T> where V : AtomVariable<T, P, E1, E2, F> where E1 : AtomEvent<T> where E2 : AtomEvent<P> where F : AtomFunction<T, T> where VI : AtomVariableInstancer<V, P, T, E1, E2, F> where AR : AtomReference<T, P, C, V, E1, E2, F, VI> where PV : PersistentVariable<T> where SP : ScriptableProperty<T> where CSP : ScriptableProperty<T> where VR : VariableReference<T, P, C, V, E1, E2, F, VI, AR, PV, SP, CSP> where CVRP : ConditionVariableReferencePair<T, P, C, V, E1, E2, F, VI, AR, PV, SP, CSP, VR>
	{
		[SerializeField]
		private VR defaultValue;

		[SerializeField]
		private List<CVRP> conditionalValues;

		protected override T GetValue()
		{
			return default(T);
		}
	}
}
