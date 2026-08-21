using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Crescive.GameStates;
using Crescive.Sequencer;
using CresciveCore;
using Cysharp.Threading.Tasks;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Offer
{
	public class OfferTriggerPointController : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COnLoadingFinishedAsync_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public OfferTriggerPointController _003C_003E4__this;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

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
		private struct _003COnSceneTypeChangedAsync_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

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

		[Header("Trigger Related")]
		[SerializeField]
		private StringVariable triggerPointValue;

		[SerializeField]
		private StringVariable currentSceneType;

		[SerializeField]
		private GameStateEvents gameStateEvents;

		[SerializeField]
		private LoaderChannel loaderChannel;

		[SerializeField]
		private VoidBaseEventReference onLevelEndGoldClaimed;

		[Header("Scene Related")]
		[SerializeField]
		private StringConstant homeSceneType;

		[SerializeField]
		private StringConstant gameSceneType;

		[Header("Trigger Points")]
		[SerializeField]
		private StringConstant sessionStartedTriggerPoint;

		[SerializeField]
		private StringConstant levelStartedTriggerPoint;

		[SerializeField]
		private StringConstant levelEndedTriggerPoint;

		[SerializeField]
		private StringConstant goldClaimedTriggerPoint;

		[SerializeField]
		private StringConstant returnedHomeTriggerPoint;

		[SerializeField]
		private OfferTriggerPointSequenceStepsData triggerPointSequenceSteps;

		[SerializeField]
		[Header("Conditions")]
		private AtomCondition canTriggerLevelStarted;

		private CancellationTokenSource cts;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void SetTriggerPoint(string value)
		{
		}

		private void OnSequenceStepStartedAsync(SequenceStep step)
		{
		}

		[AsyncStateMachine(typeof(_003COnSceneTypeChangedAsync_003Ed__21))]
		private void OnSceneTypeChangedAsync()
		{
		}

		private void OnLoadingStarted()
		{
		}

		[AsyncStateMachine(typeof(_003COnLoadingFinishedAsync_003Ed__23))]
		private void OnLoadingFinishedAsync()
		{
		}

		private void OnLevelEnded()
		{
		}

		private void OnGoldClaimed()
		{
		}

		private void CancelCancellationToken()
		{
		}

		private bool IsTriggerPointEmpty()
		{
			return false;
		}

		private bool IsInHomeScene()
		{
			return false;
		}

		private bool IsInGameScene()
		{
			return false;
		}
	}
}
