using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Ranking
{
	[DefaultExecutionOrder(1)]
	public class SingleRankingEntryController : MonoBehaviour
	{
		[SerializeField]
		[Header("References")]
		private PersistentRankingEntries rankingEntries;

		[SerializeField]
		private RankingEntry entry;

		[SerializeField]
		private IntReference entryId;

		[Header("Settings")]
		[SerializeField]
		private bool setupOnEnable;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnRankingEntriesChangedCallback(List<RankingEntryData> _)
		{
		}

		private void OnRankingEntryProfilesChangedCallback(List<RankingEntryProfileData> _)
		{
		}

		private void Setup()
		{
		}
	}
}
