using System.Collections.Generic;
using Crescive.GameStates;
using UnityAtoms;
using UnityEngine;

namespace SegmentedOffers
{
	[DefaultExecutionOrder(-100000)]
	public class SegmentedOfferServiceSync : MonoBehaviour
	{
		[SerializeField]
		private SegmentedOfferDataService service;

		[SerializeField]
		private GameStateEvents gameStateEvents;

		[SerializeField]
		private List<AtomCondition> appStartSyncConditions;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
