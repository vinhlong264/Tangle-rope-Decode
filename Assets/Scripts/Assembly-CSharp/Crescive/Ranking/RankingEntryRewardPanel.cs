using System.Collections.Generic;
using Crescive.Boosters;
using Crescive.Collection;
using Crescive.Utils;
using UnityEngine;

namespace Crescive.Ranking
{
	[DefaultExecutionOrder(1)]
	public class RankingEntryRewardPanel : MonoBehaviour
	{
		[SerializeField]
		private CollectionItemSystemsChannel collectionItemSystemsChannel;

		[SerializeField]
		private BoosterSystem boosterSystem;

		[SerializeField]
		private RankingEntryRewardComponent rewardComponentPrefab;

		[SerializeField]
		private RectTransform rewardComponentsParent;

		[SerializeField]
		private GameObject pivot;

		[SerializeField]
		private Settings<RankingEntryRewardPanelSettings> settings;

		[SerializeField]
		private RankingRewardData currentRewardData;

		[SerializeField]
		private List<RankingEntryRewardComponent> rewardComponents;

		public GameObject Pivot => null;

		private RankingEntryRewardComponent GetNewRewardComponent()
		{
			return null;
		}

		private void ClearRewardComponents()
		{
		}

		private void CreateResourceRewardComponents()
		{
		}

		private void CreateCollectionItemRewardComponents()
		{
		}

		private void CreateBoosterRewardComponents()
		{
		}

		private void CreateRandomCollectionItemRewardComponents()
		{
		}

		private void CreateRandomBoosterRewardComponents()
		{
		}

		public void SetData(RankingRewardData rewardData)
		{
		}
	}
}
