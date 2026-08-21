using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.PopUps;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.Boosters
{
	public class BoosterClaimPopupController : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCheckForPushAsync_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public BoosterClaimPopupController _003C_003E4__this;

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
		private BoosterChannel boosterChannel;

		[Space]
		[SerializeField]
		private bool autoCheckForPushOnSetupDone;

		[SerializeField]
		private bool hasTutorial;

		[Space]
		[SerializeField]
		private BoosterSystem boosterSystem;

		[SerializeField]
		private BoosterButtonsControllerChannel buttonsControllerChannel;

		[SerializeField]
		private OfferPopUp offerPopUp;

		[SerializeField]
		private Transform purchasePosition;

		[Space]
		[SerializeField]
		private Image itemIconImage;

		[SerializeField]
		private StringReference itemName;

		[SerializeField]
		private StringReference itemDescription;

		[SerializeField]
		private IntReference itemPurchaseAmount;

		[SerializeField]
		private StringReference currentLevelDifficulty;

		[SerializeField]
		private StringReference currentLevelType;

		[SerializeField]
		private StringReference hardLevelDifficulty;

		[SerializeField]
		private StringReference veryHardLevelDifficulty;

		[SerializeField]
		private StringReference stageLevel;

		private BoosterButton BoosterButton => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SyncDataToComponents()
		{
		}

		public void CheckForPush()
		{
		}

		[AsyncStateMachine(typeof(_003CCheckForPushAsync_003Ed__22))]
		private UniTaskVoid CheckForPushAsync()
		{
			return default(UniTaskVoid);
		}

		public void OnApproved()
		{
		}

		public void OnAfterApproved()
		{
		}
	}
}
