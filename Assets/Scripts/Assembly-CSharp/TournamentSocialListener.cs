using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.GameStates;
using ElephantSocial.Model;
using ElephantSocial.Tournament;
using MyBox;
using PersistentSO;
using Tournaments;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class TournamentSocialListener : Singleton<TournamentSocialListener>
{
	[CompilerGenerated]
	private sealed class _003CRaceCountdownRoutine_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TournamentSocialListener _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CRaceCountdownRoutine_003Ed__52(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private GameStateEvents gameStateEvents;

	public Action OnInitializeCallback;

	public bool isInitialized;

	public Action RaceTimeUp;

	[SerializeField]
	private FloatVariable raceTime;

	[SerializeField]
	private TournamentsDataService dataService;

	[SerializeField]
	private PersistentIntVariable level;

	[Header("Request Policy")]
	[SerializeField]
	private float requestCooldownSeconds;

	private CachedBoard _board;

	private Tournament _tournament;

	private bool _joining;

	private bool _subscribedToMgrUpdates;

	private DateTime _lastFetchUtc;

	private bool _fetchInFlight;

	private Coroutine _raceCountdownRoutine;

	private int _activeTimerTournamentId;

	public int TournamentId { get; private set; }

	public int LocalPosition
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public event Action<int> OnBoardUpdated
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

	private void OnGameWin()
	{
	}

	public void AddScore(int score)
	{
	}

	private void AddScoreToTournament(int score, int id)
	{
	}

	private bool IsTournamentReady(int id)
	{
		return false;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnSocialInitialize()
	{
	}

	private void OnLevelChanged(int _)
	{
	}

	private void Init()
	{
	}

	private void InitTournament(int id, int segmentId = -1)
	{
	}

	private bool TryGetCachedBoard(int id, out CachedBoard data)
	{
		data = null;
		return false;
	}

	public void GetBoard(Action<CachedBoard> data)
	{
	}

	public void RequestBoard(int id, Action<CachedBoard> onReady, Action onStart = null, Action onStop = null, float timeoutSeconds = -1f)
	{
	}

	private bool TryFetchResultBoard(int id)
	{
		return false;
	}

	private void GetBoardInternal(int id, Tournament t, Action onDone = null)
	{
	}

	private void OnTournamentsUpdated()
	{
	}

	private void FetchFresh(int id)
	{
	}

	public void GetResultBoard(TournamentResult result, Action<CachedBoard> onReady)
	{
	}

	public int GetPlayerRank(int id)
	{
		return 0;
	}

	public int GetPlayerRank(CachedBoard board)
	{
		return 0;
	}

	public int GetPlayerScore(CachedBoard board)
	{
		return 0;
	}

	public int GetPlayerScore(int id = -1)
	{
		return 0;
	}

	public TournamentSettings GetTournamentSettings(int id = -1)
	{
		return null;
	}

	public void JoinTournament(int segmentId = -1, Action OnJoined = null, Action OnError = null)
	{
	}

	private void StartRaceCountdown()
	{
	}

	private void StopRaceCountdown()
	{
	}

	[IteratorStateMachine(typeof(_003CRaceCountdownRoutine_003Ed__52))]
	private IEnumerator RaceCountdownRoutine()
	{
		return null;
	}

	public void OnResultClosed()
	{
	}

	private static List<BoardPlayer> SortPlayersByScoreThenUpdateTime(List<BoardPlayer> players)
	{
		return null;
	}

	public void ClearResult()
	{
	}
}
