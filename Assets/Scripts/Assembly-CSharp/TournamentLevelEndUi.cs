using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Crescive.Ads;
using UnityEngine;

public class TournamentLevelEndUi : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CHandleBoardUpdated_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int updatedTournamentId;

		public TournamentLevelEndUi _003C_003E4__this;

		private TaskAwaiter<CachedBoard> _003C_003Eu__1;

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
	private struct _003CPrimeAndRefreshAsync_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TournamentLevelEndUi _003C_003E4__this;

		private TaskAwaiter<CachedBoard> _003C_003Eu__1;

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

	[Header("UI References")]
	[SerializeField]
	private List<PlayerLadderLevelEndBadgeController> playerLadderLevelEndBadges;

	[SerializeField]
	private CresciveAdsEvents cresciveAdsEvents;

	[SerializeField]
	private GameObject pivot;

	private int tournamentId;

	private bool _subscribed;

	private CachedBoard _lastBoard;

	private bool _hasContent;

	private float _emptyGraceUntil;

	[SerializeField]
	private float emptyHideGraceSeconds;

	private void OnEnable()
	{
	}

	private void ResetUi()
	{
	}

	[AsyncStateMachine(typeof(_003CPrimeAndRefreshAsync_003Ed__11))]
	private Task PrimeAndRefreshAsync()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	[AsyncStateMachine(typeof(_003CHandleBoardUpdated_003Ed__13))]
	private void HandleBoardUpdated(int updatedTournamentId)
	{
	}

	private void SetOpen(bool isOpen)
	{
	}

	private bool RefreshUIFromBoard(CachedBoard board)
	{
		return false;
	}

	private void SoftKeepOrHide()
	{
	}

	private void ClearAll()
	{
	}

	private Task<CachedBoard> RequestBoardAsync(float timeoutSeconds)
	{
		return null;
	}
}
