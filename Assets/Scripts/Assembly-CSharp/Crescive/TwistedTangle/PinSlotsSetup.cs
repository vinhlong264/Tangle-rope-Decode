using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.Draggables;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[DefaultExecutionOrder(99999)]
	public class PinSlotsSetup : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSetupPin_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PinEntity pinEntity;

			public PinSlotsSetup _003C_003E4__this;

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
			public _003CSetupPin_003Ed__10(int _003C_003E1__state)
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
		private sealed class _003CWaitForCoroutinesToEnd_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public List<Coroutine> coroutines;

			private int _003Ci_003E5__2;

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
			public _003CWaitForCoroutinesToEnd_003Ed__9(int _003C_003E1__state)
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
		private DropTargetHoldersChannel dropTargetHoldersChannel;

		[SerializeField]
		private PinsChannel pinsChannel;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPinSetup()
		{
		}

		private void OnDropTargetHolderAdded(BaseDropTargetHolder holder)
		{
		}

		private void OnPinAdded(PinEntity pinEntity)
		{
		}

		private void Setup()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitForCoroutinesToEnd_003Ed__9))]
		private IEnumerator WaitForCoroutinesToEnd(List<Coroutine> coroutines)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSetupPin_003Ed__10))]
		private IEnumerator SetupPin(PinEntity pinEntity)
		{
			return null;
		}
	}
}
