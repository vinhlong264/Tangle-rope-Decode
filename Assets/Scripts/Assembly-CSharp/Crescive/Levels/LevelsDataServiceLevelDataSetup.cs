using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.CreatorMode;
using Crescive.TwistedTangle;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace Crescive.Levels
{
	public class LevelsDataServiceLevelDataSetup : BaseLevelDataSetup
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetLevelData_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<LevelCreatorSaveData> _003C_003Et__builder;

			public LevelsDataServiceLevelDataSetup _003C_003E4__this;

			private UniTask<LevelCreatorSaveData>.Awaiter _003C_003Eu__1;

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

		[AsyncStateMachine(typeof(_003CGetLevelData_003Ed__0))]
		protected override UniTask<LevelCreatorSaveData> GetLevelData()
		{
			return default(UniTask<LevelCreatorSaveData>);
		}
	}
}
