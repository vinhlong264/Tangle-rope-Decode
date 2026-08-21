using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Progress
{
	[CreateAssetMenu(fileName = "ProgressEventsChannel", menuName = "Crescive/Progress/Progress Events Channel")]
	public class ProgressEventsChannel : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CBindToTask_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public UniTask task;

			public ProgressEventsChannel _003C_003E4__this;

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

		public UnityEvent OnStarted;

		public UnityEvent<float> OnProgress;

		public UnityEvent OnFinished;

		public void Start()
		{
		}

		public void Progress(float progress)
		{
		}

		public void Finish()
		{
		}

		[AsyncStateMachine(typeof(_003CBindToTask_003Ed__6))]
		public void BindToTask(UniTask task)
		{
		}
	}
}
