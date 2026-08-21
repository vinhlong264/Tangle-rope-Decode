using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.CreatorMode;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Crescive.OnlineLevels
{
	public class OnlineLevelsUpdater : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdateLevelsDifficulty_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public OnlineLevelsUpdater _003C_003E4__this;

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
		private CreatorApiLevelsDifficultyUpdater difficultyUpdater;

		[SerializeField]
		private OnlineLevelsDataService service;

		[SerializeField]
		private DifficultyUpdateData difficultyUpdateData;

		public void PasteDifficultiesFromClipboard()
		{
		}

		[AsyncStateMachine(typeof(_003CUpdateLevelsDifficulty_003Ed__4))]
		public void UpdateLevelsDifficulty()
		{
		}
	}
}
