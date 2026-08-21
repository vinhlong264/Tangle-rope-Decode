using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.Draggables;
using Crescive.Tutorials;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[DefaultExecutionOrder(999999999)]
	public class PinTutorialController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDoNextFrameNumerator_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PinTutorialController _003C_003E4__this;

			public Action action;

			private IEnumerator<PinEntity> _003C_003E7__wrap1;

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
			public _003CDoNextFrameNumerator_003Ed__8(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private PinsChannel pinsChannel;

		[SerializeField]
		private PinSlotsChannel pinsSlotChannel;

		[SerializeField]
		private AssistHandAnimLooper handLooper;

		[SerializeField]
		private DefaultDropTargetHolder sourceHolder;

		[SerializeField]
		private DefaultDropTargetHolder targetHolder;

		[SerializeField]
		private bool setRunTime;

		private PinEntity currentPin;

		private void DoNextFrame(Action action)
		{
		}

		[IteratorStateMachine(typeof(_003CDoNextFrameNumerator_003Ed__8))]
		private IEnumerator DoNextFrameNumerator(Action action)
		{
			return null;
		}

		private void SetupInternal()
		{
		}

		private void SetupInternal(int objectIndex)
		{
		}

		private void SetupPins(Draggable currentDraggable, List<PinEntity> otherPins, int objectIndex = 0)
		{
		}

		public void ReActivePins()
		{
		}

		public void Setup()
		{
		}

		public void Setup(int objIndex)
		{
		}
	}
}
