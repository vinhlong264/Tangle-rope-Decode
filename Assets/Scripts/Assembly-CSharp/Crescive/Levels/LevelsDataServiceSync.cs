using System.Collections.Generic;
using Systems.Randomization.Scripts;
using Crescive.GameStates;
using SegmentedOffers;
using UnityAtoms;
using UnityEngine;

namespace Crescive.Levels
{
	[DefaultExecutionOrder(-100000)]
	public class LevelsDataServiceSync : MonoBehaviour
	{
		[SerializeField]
		private SegmentedOfferDataService segmentedOfferDataService;

		[SerializeField]
		private RandomizationDataService randomizationDataService;

		[SerializeField]
		private GameStateEvents gameStateEvents;

		[SerializeField]
		private float syncDelayOnWin;

		[SerializeField]
		private List<AtomCondition> appStartSyncConditions;

		[SerializeField]
		private List<AtomCondition> winSyncConditions;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPlay()
		{
		}

		private void OnWin()
		{
		}
	}
}
