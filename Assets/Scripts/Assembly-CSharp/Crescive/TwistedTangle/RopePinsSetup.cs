using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	[DefaultExecutionOrder(100)]
	public class RopePinsSetup : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSetupPinsCoroutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RopePinsSetup _003C_003E4__this;

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
			public _003CSetupPinsCoroutine_003Ed__19(int _003C_003E1__state)
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
		private PinsChannel pinsChannel;

		[SerializeField]
		private RopeConnection ropeConnection;

		[SerializeField]
		private float maxSearchDistance;

		[SerializeField]
		[Range(0f, 1f)]
		private float visualizePercent;

		public UnityEvent OnSetup;

		public PinEntity StartPin { get; private set; }

		public PinEntity EndPin { get; private set; }

		private void Start()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private PinEntity GetStartPin()
		{
			return null;
		}

		private PinEntity GetEndPin()
		{
			return null;
		}

		private void SetupStartPin()
		{
		}

		private void SetupEndPin()
		{
		}

		[IteratorStateMachine(typeof(_003CSetupPinsCoroutine_003Ed__19))]
		private IEnumerator SetupPinsCoroutine()
		{
			return null;
		}

		public Vector3 GetParticlePositionAtPercent(float percent)
		{
			return default(Vector3);
		}

		public Vector3 GetStartParticlePosition()
		{
			return default(Vector3);
		}

		public Vector3 GetEndParticlePosition()
		{
			return default(Vector3);
		}

		public void SetupPins()
		{
		}
	}
}
