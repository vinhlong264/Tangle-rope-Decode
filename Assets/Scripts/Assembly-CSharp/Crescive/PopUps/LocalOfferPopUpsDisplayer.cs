using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.HelperTypes;
using Crescive.Offer;
using Cysharp.Threading.Tasks;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.PopUps
{
	[DefaultExecutionOrder(-1000000)]
	public class LocalOfferPopUpsDisplayer : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDisplayPopUps_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public LocalOfferPopUpsDisplayer _003C_003E4__this;

			private List<LocalOfferPopUpController> _003CpopUpsToShow_003E5__2;

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
		private OfferControllerChannel offerControllerChannel;

		[SerializeField]
		private List<LocalOfferPopUpController> popUps;

		[SerializeField]
		private IntReference maxPopUpsToShow;

		[SerializeField]
		private StringVariable currentTriggerPoint;

		[SerializeField]
		private BoolSettableVariableReference isDisplayPopUpsRunning;

		private Queue<LocalOfferPopUpController> popUpQueue;

		public UnityEvent<bool> OnDisplayPopUpsResult;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnCurrentTriggerPointChanged()
		{
		}

		[AsyncStateMachine(typeof(_003CDisplayPopUps_003Ed__10))]
		private void DisplayPopUps()
		{
		}

		private void ShowPopUpFromQueue()
		{
		}

		private void OnAnyPopUpHideCallback(PopUp popUp)
		{
		}
	}
}
