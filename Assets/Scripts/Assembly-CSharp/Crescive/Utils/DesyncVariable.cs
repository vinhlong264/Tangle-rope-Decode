using System.Collections.Generic;
using Crescive.HelperTypes;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms;
using UnityEngine;

namespace Crescive.Utils
{
	public abstract class DesyncVariable<T, P, C, V, E1, E2, F, VI, PV, SSP, SVR> : BaseDesyncVariable where P : struct, IPair<T> where C : AtomBaseVariable<T> where V : AtomVariable<T, P, E1, E2, F> where E1 : AtomEvent<T> where E2 : AtomEvent<P> where F : AtomFunction<T, T> where VI : AtomVariableInstancer<V, P, T, E1, E2, F> where PV : PersistentVariable<T> where SSP : SettableScriptableProperty<T> where SVR : SettableVariableReference<T, P, C, V, E1, E2, F, VI, PV, SSP>
	{
		[SerializeField]
		[Space]
		private SVR realVariable;

		[SerializeField]
		private List<SVR> desyncVariables;

		[SerializeField]
		private List<SVR> runtimeDesyncVariables;

		public SVR RealVariable => null;

		private void OnRealVariableChanged(T value)
		{
		}

		public void SyncDesyncVariablesToReal()
		{
		}

		protected override void SetupInternal()
		{
		}

		protected override void DisposeInternal()
		{
		}

		protected override void SetSyncingInternal(bool value)
		{
		}

		private void ClearRuntimeDesyncVariables()
		{
		}

		public void AddRuntimeDesyncVariable(SVR desyncVariable)
		{
		}

		public void RemoveRuntimeDesyncVariable(SVR desyncVariable)
		{
		}
	}
}
