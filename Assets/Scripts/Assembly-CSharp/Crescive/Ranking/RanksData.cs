using System;
using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Ranking
{
	[CreateAssetMenu(fileName = "RanksData", menuName = "Crescive/UI/RanksData", order = 0)]
	public class RanksData : ScriptableObject
	{
		[Serializable]
		public struct RankData
		{
			public int rank;

			public Sprite rankImage;
		}

		[SerializeField]
		private List<RankData> rankDataList;

		public RankData GetRankData(int rank)
		{
			return default(RankData);
		}
	}
}
