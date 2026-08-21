using UnityEngine;
using UnityEngine.Events;

namespace Crescive.League
{
	public class LiveLeagueDataServiceListener : MonoBehaviour
	{
		[SerializeField]
		private LiveLeagueDataService service;

		public UnityEvent OnNewLeagueStarted;

		public UnityEvent OnEnteredLeague;

		public UnityEvent OnExitedLeague;

		public UnityEvent OnLeagueFinished;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
