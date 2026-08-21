using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.CreatorMode;
using Crescive.HelperTypes;
using Crescive.Levels;
using CresciveCore;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Game.Systems.StageLevels
{
	public class StageLevelsManager : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadNextStageAsync_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public StageLevelsManager _003C_003E4__this;

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
		private IntSettableVariableReference currentStageIndex;

		[SerializeField]
		private BoolSettableVariableReference isSwitchingLevelStage;

		[SerializeField]
		private BoolSettableVariableReference isStagedLevel;

		[SerializeField]
		private IntSettableVariableReference timeLimit;

		[SerializeField]
		private LevelCreatorChannel levelCreatorChannel;

		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private LoadedLevelDataChannel loadedLevelDataChannel;

		[SerializeField]
		private VoidBaseEventReference levelCreatedEvent;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnLevelStarted()
		{
		}

		private void OnStageLevelMapStageCleared()
		{
		}

		[AsyncStateMachine(typeof(_003CLoadNextStageAsync_003Ed__12))]
		private UniTask LoadNextStageAsync()
		{
			return default(UniTask);
		}
	}
}
