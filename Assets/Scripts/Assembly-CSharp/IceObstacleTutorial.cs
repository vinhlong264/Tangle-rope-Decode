using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Crescive.GameStates;
using Crescive.Navigation;
using Crescive.TwistedTangle;
using Cysharp.Threading.Tasks;
using PersistentSO;
using UnityEngine;

public class IceObstacleTutorial : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003COnLevelStartedCallback_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public IceObstacleTutorial _003C_003E4__this;

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
	private Navigatable iceObstacleTutorialPopup;

	[SerializeField]
	private GameStateEvents gameStateEvents;

	[SerializeField]
	private TutorialCanvas canvasPrefab;

	[SerializeField]
	private PersistentBoolVariable isIceObstacleTutorialCompleted;

	[SerializeField]
	private PersistentBoolVariable isColoredIceObstacleTutorialCompleted;

	[SerializeField]
	private string iceObstacleLevelName;

	[SerializeField]
	private string coloredIceObstacleLevelName;

	[SerializeField]
	private HammerControllerChannel hammerControllerChannel;

	private int revealedCount;

	private CancellationTokenSource revealCTS;

	private PersistentBoolVariable currentIsIceObstacleTutorialCompleted;

	private TutorialCanvas _tutorialCanvas;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[AsyncStateMachine(typeof(_003COnLevelStartedCallback_003Ed__15))]
	private void OnLevelStartedCallback(LevelEvents.OnStageCreated stageCreated)
	{
	}

	private void CheckIceObstacleTutorial()
	{
	}

	private void OpenTutorial(bool isColored)
	{
	}
}
