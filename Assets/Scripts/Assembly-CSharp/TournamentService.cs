using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public sealed class TournamentService : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CRequestBoardAsync_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TournamentService _003C_003E4__this;

		public float timeoutSeconds;

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

	private CancellationTokenSource _loadCts;

	private bool _subscribed;

	private int TournamentId { get; set; }

	public CachedBoard LastBoard { get; private set; }

	public List<TournamentPrize> Prizes { get; }

	public event Action<CachedBoard> BoardReady
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<TournamentResultPayload> ResultReady
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action ResultClosed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Init(int tournamentId, bool refreshOnUpdates)
	{
	}

	private void OnDisable()
	{
	}

	private void HandleBoardUpdated(int updatedId)
	{
	}

	[AsyncStateMachine(typeof(_003CRequestBoardAsync_003Ed__25))]
	public Task RequestBoardAsync(bool forceRefresh, float timeoutSeconds = 1f)
	{
		return null;
	}

	public void JoinTournament(Action OnJoined, Action OnError)
	{
	}

	public void EmitExistingResultIfAny()
	{
	}

	private void TryEmitResult()
	{
	}

	public int GetPlayerFinalPosition(TournamentResultPayload payload)
	{
		return 0;
	}

	public int GetPlayerFinalScore(TournamentResultPayload payload)
	{
		return 0;
	}

	public void CloseResultAndRefresh()
	{
	}
}
