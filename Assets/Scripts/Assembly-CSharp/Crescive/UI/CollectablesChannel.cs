using System.Collections.Generic;
using Crescive.Rewards;
using UnityEngine;

namespace Crescive.UI
{
	[CreateAssetMenu(fileName = "CollectablesChannel", menuName = "Crescive/Collectables/CollectablesChannel")]
	public class CollectablesChannel : ScriptableObject, IResettableObject
	{
		[SerializeField]
		private List<BaseDailyRewardData> collectables;

		public IReadOnlyList<BaseDailyRewardData> Collectables => null;

		public void ResetData()
		{
		}

		public void Add(BaseDailyRewardData item)
		{
		}
	}
}
