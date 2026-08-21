using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Crescive.CreatorMode
{
	public class CreatorApiLevelsDifficultyUpdater : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdateLevelDifficulty_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CreatorApiLevelsDifficultyUpdater _003C_003E4__this;

			public string levelId;

			public string difficulty;

			private UniTask<CreatorModeAPI.Models.LevelModel>.Awaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

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
		private struct _003CUpdateLevelsDifficulty_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public List<string> levelIds;

			public List<string> difficulties;

			public CreatorApiLevelsDifficultyUpdater _003C_003E4__this;

			private int _003Ci_003E5__2;

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
		private CreatorApiRequestLevelIntegration levelIntegration;

		[AsyncStateMachine(typeof(_003CUpdateLevelDifficulty_003Ed__1))]
		public UniTask UpdateLevelDifficulty(string levelId, string difficulty)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(_003CUpdateLevelsDifficulty_003Ed__2))]
		public UniTask UpdateLevelsDifficulty(List<string> levelIds, List<string> difficulties)
		{
			return default(UniTask);
		}
	}
}
