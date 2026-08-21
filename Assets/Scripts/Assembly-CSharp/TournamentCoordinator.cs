using UnityEngine;

[RequireComponent(typeof(AnalyticsReporter))]
[RequireComponent(typeof(AutoCenterController))]
[RequireComponent(typeof(ResultPanel))]
[RequireComponent(typeof(LadderAnimator))]
[RequireComponent(typeof(LadderView))]
[RequireComponent(typeof(TournamentService))]
[RequireComponent(typeof(TournamentTutorialController))]
public class TournamentCoordinator : MonoBehaviour
{
	[Header("Options")]
	[SerializeField]
	private bool refreshOnUpdates;

	[SerializeField]
	private GameObject loadingText;

	private TournamentService _service;

	private LadderView _view;

	private LadderAnimator _anim;

	private TournamentTutorialController _tutorial;

	private ResultPanel _result;

	private AutoCenterController _autoCenter;

	private AnalyticsReporter _analytics;

	private int _tournamentId;

	private bool _started;

	private void Reset()
	{
	}

	public void OnShown()
	{
	}

	public void OnHide()
	{
	}

	private void OnBoardReady(CachedBoard board)
	{
	}

	private void OnResultReady(TournamentResultPayload payload)
	{
	}

	private void OnResultClosed()
	{
	}

	private void SetLoading(bool on)
	{
	}

	private void Update()
	{
	}

	public void RefreshAnimation()
	{
	}

	public void SetLocalPosition(int findMyRank)
	{
	}
}
