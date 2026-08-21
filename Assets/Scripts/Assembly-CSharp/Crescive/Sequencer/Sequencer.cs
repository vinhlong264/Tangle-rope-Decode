using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Sequencer
{
	public class Sequencer : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStartSequenceAsync_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public Sequencer _003C_003E4__this;

			private CancellationToken _003CcancellationToken_003E5__2;

			private List<SequenceStep> _003CactiveSteps_003E5__3;

			private List<SequenceStep>.Enumerator _003C_003E7__wrap3;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[SerializeField]
		private SequencerChannel data;

		[SerializeField]
		private bool cancelOnDisable;

		public UnityEvent OnSequenceStarted;

		public UnityEvent OnSequenceFinished;

		public UnityEvent OnSequenceCanceled;

		public UnityEvent OnSequenceFinishedOrCanceled;

		private CancellationTokenSource cancellationTokenSource;

		public SequenceStep ActiveSequenceStep => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[AsyncStateMachine(typeof(_003CStartSequenceAsync_003Ed__11))]
		private void StartSequenceAsync()
		{
		}

		private static void ResetSteps(List<SequenceStep> activeSteps)
		{
		}

		public void StartSequence()
		{
		}
	}
}
