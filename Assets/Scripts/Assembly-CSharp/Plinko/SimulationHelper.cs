using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Plinko
{
	public class SimulationHelper : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSimulatePercentages_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SimulationHelper _003C_003E4__this;

			private int _003CsimulateCountPerSpawner_003E5__2;

			private int _003Ci_003E5__3;

			private string _003Clog_003E5__4;

			private int _003Cj_003E5__5;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSimulatePercentages_003Ed__7(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private int SimulatePerSpawnerCount;

		[SerializeField]
		private RewardAreaTrigger[] rewardAreaTriggers;

		[SerializeField]
		private Spawner spawner;

		private Coroutine simulationRoutine;

		private WaitForSeconds wait;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[IteratorStateMachine(typeof(_003CSimulatePercentages_003Ed__7))]
		private IEnumerator SimulatePercentages()
		{
			return null;
		}
	}
}
