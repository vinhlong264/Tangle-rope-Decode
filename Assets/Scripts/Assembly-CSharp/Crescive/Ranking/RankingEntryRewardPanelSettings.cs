using System;
using System.Collections.Generic;
using Crescive.Text;
using UnityEngine;

namespace Crescive.Ranking
{
	[Serializable]
	public class RankingEntryRewardPanelSettings
	{
		public List<RankingEntryRewardResourceComponentData> resourceComponentsData;

		public Sprite randomItemsIcon;

		public Sprite randomBoostersIcon;

		[Space]
		public string resourcePrefix;

		public FloatTextFormatter resourceTextFormatter;

		public string boosterPrefix;

		public FloatTextFormatter boosterTextFormatter;

		public string GetResourceString(float amount)
		{
			return null;
		}

		public string GetBoosterString(float amount)
		{
			return null;
		}

		public string GetRandomCollectionItemString(int amount)
		{
			return null;
		}

		public string GetRandomBoosterString(int amount)
		{
			return null;
		}
	}
}
