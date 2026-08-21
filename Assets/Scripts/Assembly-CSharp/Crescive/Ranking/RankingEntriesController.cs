using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Ranking
{
	public class RankingEntriesController : MonoBehaviour
	{
		[SerializeField]
		[Header("References")]
		private PersistentRankingEntries rankingEntries;

		[SerializeField]
		private RankingRewardsDataService rewardsDataService;

		[SerializeField]
		private RankingEntry entryPrefab;

		[SerializeField]
		private RankingEntry playerEntryPrefab;

		[SerializeField]
		private RectTransform entriesParent;

		[Header("Settings")]
		[SerializeField]
		private bool showAllEntries;

		[SerializeField]
		private int entryCount;

		[SerializeField]
		private bool showRewards;

		[Header("State")]
		[SerializeField]
		private bool didSetupOnce;

		[SerializeField]
		private List<RankingEntry> entries;

		[SerializeField]
		private RankingEntry playerEntry;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void UpdateEntries(List<RankingEntryData> filteredEntriesData, int skipCount)
		{
		}

		private void OrderEntries()
		{
		}

		private void PlacePlayerInRightPlace(List<RankingEntryData> filteredEntriesData)
		{
		}

		private void OnRankingEntriesChangedCallback(List<RankingEntryData> _)
		{
		}

		private void OnRankingEntryProfilesChangedCallback(List<RankingEntryProfileData> _)
		{
		}

		public void Setup()
		{
		}
	}
}
