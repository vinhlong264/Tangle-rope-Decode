using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.CreatorMode;
using Crescive.TwistedTangle;
using Obi;
using UnityEngine;

namespace Crescive.Collection.Preview
{
	public class PreviewLevelCreator : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			public RopeEntity ropeEntity;

			internal bool _003CSetupRopeParticlesCoroutine_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CSetupRopeParticlesCoroutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RopeEntity ropeEntity;

			private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

			public PreviewLevelCreator _003C_003E4__this;

			public RopeData ropeData;

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
			public _003CSetupRopeParticlesCoroutine_003Ed__8(int _003C_003E1__state)
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
		private sealed class _003CStart_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PreviewLevelCreator _003C_003E4__this;

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
			public _003CStart_003Ed__9(int _003C_003E1__state)
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
		private LevelCreatorData creatorData;

		[SerializeField]
		private PinEntity pinPrefab;

		[SerializeField]
		public RopeEntity ropePrefab;

		[SerializeField]
		private Transform pinsParent;

		[SerializeField]
		private Transform ropesParent;

		private Dictionary<RopeEntity, RopeData> ropesData;

		private void OnEnable()
		{
		}

		private void ResetRopes()
		{
		}

		[IteratorStateMachine(typeof(_003CSetupRopeParticlesCoroutine_003Ed__8))]
		private IEnumerator SetupRopeParticlesCoroutine(RopeEntity ropeEntity, RopeData ropeData)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__9))]
		private IEnumerator Start()
		{
			return null;
		}

		private void CreatePins(List<PinData> pinsData)
		{
		}

		private void CreateRopes(List<RopeData> ropesData)
		{
		}

		private void CreatePin(PinData pinData)
		{
		}

		private void CreateRope(RopeData ropeData)
		{
		}

		private void SetupRopeParticles(ObiRope rope, RopeData ropeData)
		{
		}
	}
}
