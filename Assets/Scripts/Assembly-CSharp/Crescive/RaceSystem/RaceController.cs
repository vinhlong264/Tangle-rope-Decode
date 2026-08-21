using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using RSG;
using UnityAtoms;
using UnityEngine;

namespace Crescive.RaceSystem
{
	[DefaultExecutionOrder(1)]
	public class RaceController : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetRaceStatusDelayed_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public RaceController _003C_003E4__this;

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
		[Header("References")]
		private RaceSystem raceSystem;

		[Header("Conditions")]
		[SerializeField]
		private AtomCondition raceOfferCondition;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void GetRaceStatusAndTriggerEvents()
		{
		}

		private RaceStatus ProcessRaceStatus(RaceStatusData statusData)
		{
			return default(RaceStatus);
		}

		[AsyncStateMachine(typeof(_003CGetRaceStatusDelayed_003Ed__7))]
		private void GetRaceStatusDelayed()
		{
		}

		private void AcceptRace()
		{
		}

		private void DeclineRace()
		{
		}

		private void ConfirmRaceFinished()
		{
		}

		public void TriggerGetRaceStatusAndTriggerEvents()
		{
		}

		public RSG.IPromise<RaceStatus> GetRaceStatus()
		{
			return null;
		}
	}
}
