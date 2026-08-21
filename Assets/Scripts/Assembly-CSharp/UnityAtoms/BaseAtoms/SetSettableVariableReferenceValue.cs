using Crescive.HelperTypes;
using Crescive.Scriptables;
using PersistentSO;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	public abstract class SetSettableVariableReferenceValue<T, P, C, V, E1, E2, F, VI, AR, PV, SP, SSP, CSP, VR, SVR> : AtomAction where P : struct, IPair<T> where C : AtomBaseVariable<T> where V : AtomVariable<T, P, E1, E2, F> where E1 : AtomEvent<T> where E2 : AtomEvent<P> where F : AtomFunction<T, T> where VI : AtomVariableInstancer<V, P, T, E1, E2, F> where AR : AtomReference<T, P, C, V, E1, E2, F, VI> where PV : PersistentVariable<T> where SP : ScriptableProperty<T> where SSP : SettableScriptableProperty<T> where CSP : ScriptableProperty<T> where VR : VariableReference<T, P, C, V, E1, E2, F, VI, AR, PV, SP, CSP> where SVR : SettableVariableReference<T, P, C, V, E1, E2, F, VI, PV, SSP>
	{
		[SerializeField]
		private VR value;

		[SerializeField]
		private SVR[] targets;

		public override void Do()
		{
		}
	}
}
