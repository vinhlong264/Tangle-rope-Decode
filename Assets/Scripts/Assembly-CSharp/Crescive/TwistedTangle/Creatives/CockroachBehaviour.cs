using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle.Creatives
{
	public class CockroachBehaviour : MonoBehaviour, ICrushInteraction
	{
		[CompilerGenerated]
		private sealed class _003CCo_DelayedRemoval_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CockroachBehaviour _003C_003E4__this;

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
			public _003CCo_DelayedRemoval_003Ed__22(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CCo_RotateRandomlyInRandomTimes_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CockroachBehaviour _003C_003E4__this;

			private Quaternion _003CtargetRotation_003E5__2;

			private float _003CelapsedTime_003E5__3;

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
			public _003CCo_RotateRandomlyInRandomTimes_003Ed__20(int _003C_003E1__state)
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
		private float speed;

		[SerializeField]
		private float maxLifetime;

		[SerializeField]
		private float avoidanceDistance;

		[SerializeField]
		private float rotationSpeed;

		[SerializeField]
		private float minRotationOffset;

		[SerializeField]
		private float maxRotationOffset;

		[SerializeField]
		private float minRandomRotationTime;

		[SerializeField]
		private float maxRandomRotationTime;

		[SerializeField]
		private float spawnDuration;

		[SerializeField]
		private Transform roachModelTransform;

		[SerializeField]
		private GameObject splashEffect;

		[SerializeField]
		private float delayedDeathDuration;

		[SerializeField]
		private Transform particleSpawnTransform;

		[SerializeField]
		private VoidEvent playRandomSoundEvent;

		private float lifetime;

		private bool isDead;

		private Transform splatTransform;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void GetSpawned()
		{
		}

		[IteratorStateMachine(typeof(_003CCo_RotateRandomlyInRandomTimes_003Ed__20))]
		private IEnumerator Co_RotateRandomlyInRandomTimes()
		{
			return null;
		}

		private void DeathByTimer()
		{
		}

		[IteratorStateMachine(typeof(_003CCo_DelayedRemoval_003Ed__22))]
		private IEnumerator Co_DelayedRemoval()
		{
			return null;
		}

		public void CrushHit()
		{
		}
	}
}
