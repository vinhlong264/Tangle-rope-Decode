using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.TwistedTangle;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Crescive.CreatorMode
{
	public class CreatorApiOrderedLevelsSaver : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSaveOrderedLevelsFromClipboard_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CreatorApiOrderedLevelsSaver _003C_003E4__this;

			private LevelSaver _003Csaver_003E5__2;

			private string[] _003C_003E7__wrap2;

			private int _003C_003E7__wrap3;

			private string _003Cid_003E5__5;

			private UniTask.Awaiter _003C_003Eu__1;

			private UniTask<CreatorModeAPI.Models.LevelModel>.Awaiter _003C_003Eu__2;

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
		private LevelSaverChannel saverChannel;

		[SerializeField]
		private CreatorApiRequestLevelIntegration levelIntegration;

		[AsyncStateMachine(typeof(_003CSaveOrderedLevelsFromClipboard_003Ed__2))]
		public UniTask SaveOrderedLevelsFromClipboard()
		{
			return default(UniTask);
		}
	}
}
