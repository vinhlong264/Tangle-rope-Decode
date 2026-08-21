using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TutorialCanvas : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CRevealSequenceAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public TutorialCanvas _003C_003E4__this;

		public CancellationToken token;

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
	private List<GameObject> iceObstacleSequenceObjects;

	[SerializeField]
	private List<GameObject> coloredIceObstacleSequenceObjects;

	[SerializeField]
	private Button closeButton;

	private List<GameObject> currentSequenceList;

	private int revealedCount;

	private CancellationTokenSource revealCTS;

	private Action onTutorialComplete;

	public void Initialize(bool isColored, Action onCompleteCallback = null)
	{
	}

	[AsyncStateMachine(typeof(_003CRevealSequenceAsync_003Ed__8))]
	private UniTaskVoid RevealSequenceAsync(CancellationToken token)
	{
		return default(UniTaskVoid);
	}

	private void OnCloseClicked()
	{
	}

	private void DisposeRevealCTS()
	{
	}

	private void OnDisable()
	{
	}

	public void DestroySelf()
	{
	}
}
