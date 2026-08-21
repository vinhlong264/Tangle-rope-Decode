using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PersistentSO;
using UnityEngine;

namespace Crescive.TwistedTangle.Creatives
{
	public class CockroachSpawner : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCo_SpawnCockroach_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CockroachSpawner _003C_003E4__this;

			private float _003CremainingDuration_003E5__2;

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
			public _003CCo_SpawnCockroach_003Ed__9(int _003C_003E1__state)
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
		private CockroachBehaviour[] Cockroach;

		[SerializeField]
		private PersistentFloatVariable roachSpawnDurationPersistent;

		[SerializeField]
		private PersistentFloatVariable roachSpawnIntervalPersistent;

		private float spawnInterval;

		private float spawnDuration;

		private Coroutine spawnCoroutine;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void SpawnCockroach()
		{
		}

		[IteratorStateMachine(typeof(_003CCo_SpawnCockroach_003Ed__9))]
		private IEnumerator Co_SpawnCockroach()
		{
			return null;
		}

		public void StartSpawning()
		{
		}

		public void StopSpawning()
		{
		}
	}
}
