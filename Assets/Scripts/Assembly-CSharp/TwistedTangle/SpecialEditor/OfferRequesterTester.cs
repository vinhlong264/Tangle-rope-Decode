using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.Offer;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace TwistedTangle.SpecialEditor
{
	public class OfferRequesterTester : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetRequest_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public OfferRequesterTester _003C_003E4__this;

			private UniTask<ElephantSDK.OfferData>.Awaiter _003C_003Eu__1;

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
		private OfferRequester offerRequester;

		[SerializeField]
		private TextMeshProUGUI offerDataText;

		[AsyncStateMachine(typeof(_003CGetRequest_003Ed__2))]
		private void GetRequest()
		{
		}

		public void TriggerRequest()
		{
		}
	}
}
