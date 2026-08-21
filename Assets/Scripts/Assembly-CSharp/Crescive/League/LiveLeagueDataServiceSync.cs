using System.Collections.Generic;
using CresciveCore;
using UnityAtoms;
using UnityEngine;

namespace Crescive.League
{
	[DefaultExecutionOrder(-10)]
	public class LiveLeagueDataServiceSync : MonoBehaviour
	{
		[SerializeField]
		private LiveLeagueDataService leagueService;

		[SerializeField]
		private List<AtomCondition> appStartSyncConditions;

		[SerializeField]
		private LoaderChannel loaderChannel;

		private bool isSubscribedToLoader;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SubscribeToLoader()
		{
		}

		private void UnsubscribeFromLoader()
		{
		}

		private void OnLoopLevelCompleted()
		{
		}

		private void OnLoadingHomeStarted()
		{
		}
	}
}
