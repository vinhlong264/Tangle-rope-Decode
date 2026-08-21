using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.CreatorMode;
using Crescive.HelperTypes;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UI
{
	public class StageLevelProgressBarUIControllerNewTheme : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStartAnimation_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public StageLevelProgressBarUIControllerNewTheme _003C_003E4__this;

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
		private StringReference currentLevelDifficulty;

		[SerializeField]
		private StringReference hardLevelDifficulty;

		[SerializeField]
		private StringReference veryHardLevelDifficulty;

		[SerializeField]
		private IntSettableVariableReference currentStageIndex;

		[SerializeField]
		private GameObject setActiveParent;

		[SerializeField]
		private List<StagePointController> midStagePoints;

		[SerializeField]
		private StagePointController startStagePoint;

		[SerializeField]
		private StagePointController endStagePoint;

		private List<StagePointController> _stagePointControllers;

		[SerializeField]
		private LevelCreatorChannel levelCreatorChannel;

		private void OnEnable()
		{
		}

		private void OnLevelCreated(LevelEvents.OnStageLevelCreated obj)
		{
		}

		private void OnDisable()
		{
		}

		private void OnStageLevelIndexChanged(LevelEvents.OnStageCreated obj)
		{
		}

		private void ResetUi()
		{
		}

		private void ResetUiWithAnimation()
		{
		}

		[AsyncStateMachine(typeof(_003CStartAnimation_003Ed__16))]
		private UniTaskVoid StartAnimation()
		{
			return default(UniTaskVoid);
		}

		private void OnStageLevelDone(LevelEvents.OnStageLevelMapStageCleared obj)
		{
		}

		private void Update()
		{
		}
	}
}
