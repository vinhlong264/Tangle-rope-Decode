using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Ranking
{
	[DefaultExecutionOrder(1)]
	public class PersistentRankingEntriesEntryGetter : MonoBehaviour
	{
		[SerializeField]
		private PersistentRankingEntries persistentRankingEntries;

		[SerializeField]
		[Space]
		private IntReference entryId;

		[SerializeField]
		private AutoTriggerMethod autoTriggerMethods;

		public UnityEvent<string> OnGetPlayerName;

		public UnityEvent<int> OnGetRank;

		public UnityEvent<float> OnGetScore;

		public UnityEvent<string> OnGetCountryCode;

		public UnityEvent<int> OnGetIconId;

		public UnityEvent<int> OnGetIconColorId;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnPersistentRankingEntriesChangedCallback(List<RankingEntryData> _)
		{
		}

		public void TriggerEvents()
		{
		}
	}
}
