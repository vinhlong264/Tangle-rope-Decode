using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.GameStates;
using Cysharp.Threading.Tasks;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace ElephantSDK
{
	public class ElephantLevelEventsByTypeSender : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COnLevelCompletedCallback_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ElephantLevelEventsByTypeSender _003C_003E4__this;

			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COnLevelFailedCallback_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ElephantLevelEventsByTypeSender _003C_003E4__this;

			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COnLevelGiveUpCallback_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ElephantLevelEventsByTypeSender _003C_003E4__this;

			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COnLevelStartedCallback_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ElephantLevelEventsByTypeSender _003C_003E4__this;

			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

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

		[Header("Condition")]
		[SerializeField]
		private AtomCondition triggerCondition;

		[Header("References")]
		[SerializeField]
		private GameStateEvents gameStateEvents;

		[SerializeField]
		private VoidBaseEventReference levelGiveUpEvent;

		[SerializeField]
		private BaseElephantLevelEventNumbersSource levelNumbersSource;

		[Header("Events")]
		public UnityEvent<LevelEventArgs> OnLevelStarted;

		public UnityEvent<LevelEventArgs> OnLevelCompleted;

		public UnityEvent<LevelEventArgs> OnLevelFailed;

		public UnityEvent<LevelEventArgs> OnLevelGiveUp;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[AsyncStateMachine(typeof(_003COnLevelStartedCallback_003Ed__10))]
		private void OnLevelStartedCallback()
		{
		}

		[AsyncStateMachine(typeof(_003COnLevelCompletedCallback_003Ed__11))]
		private void OnLevelCompletedCallback()
		{
		}

		[AsyncStateMachine(typeof(_003COnLevelFailedCallback_003Ed__12))]
		private void OnLevelFailedCallback()
		{
		}

		[AsyncStateMachine(typeof(_003COnLevelGiveUpCallback_003Ed__13))]
		private void OnLevelGiveUpCallback()
		{
		}

		private LevelEventArgs GetEventArgs()
		{
			return null;
		}
	}
}
