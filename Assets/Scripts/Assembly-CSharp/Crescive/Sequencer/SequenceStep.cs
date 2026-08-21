using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Crescive.HelperTypes;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Sequencer
{
	[CreateAssetMenu(fileName = "Sequence Step", menuName = "Crescive/Sequencer/Step/Sequence Step")]
	public class SequenceStep : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStartStepAsync_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public SequenceStep _003C_003E4__this;

			public CancellationToken cancellationToken;

			private UniTask.Awaiter _003C_003Eu__1;

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
		private List<BoolVariableReference> activeConditions;

		[SerializeField]
		private SequenceStepFinishConditionType finishConditionType;

		[SerializeField]
		private List<BoolVariableReference> externalFinishConditions;

		[SerializeField]
		private bool usesSubSteps;

		[SerializeField]
		private SequenceSubStepFactory subStepFactory;

		private bool isStarted;

		private bool isFinishCalled;

		private bool isCompleted;

		[SerializeField]
		private List<SequenceSubStep> subSteps;

		public UnityEvent<SequenceStep> OnStepStarted;

		public UnityEvent<SequenceStep> OnStepEnded;

		public UnityEvent<SequenceStep> OnStepChanged;

		public UnityEvent<SequenceSubStep> OnSubStepStarted;

		private SequenceSubStep CurrentSubStep => null;

		public bool UsesSubSteps => false;

		public bool IsActive => false;

		public bool IsStarted => false;

		public bool IsFinishCalled => false;

		public bool IsCompleted => false;

		private bool ShouldShowExternalFinishConditions()
		{
			return false;
		}

		private bool ShouldShowIsFinished()
		{
			return false;
		}

		private bool CheckIsFinishCalled()
		{
			return false;
		}

		private bool CheckExternal()
		{
			return false;
		}

		private bool CheckBoth()
		{
			return false;
		}

		private Func<bool> GetCheckFinishedAction()
		{
			return null;
		}

		private bool IsCurrentSubStepFinished()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CStartStepAsync_003Ed__32))]
		public UniTask StartStepAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public void FinishStep()
		{
		}

		public void FinishStepIfStarted()
		{
		}

		public void ResetStep()
		{
		}
	}
}
