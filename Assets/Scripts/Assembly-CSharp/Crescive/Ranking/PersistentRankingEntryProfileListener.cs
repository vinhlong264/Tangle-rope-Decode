using PersistentSO;
using UnityEngine;

namespace Crescive.Ranking
{
	public class PersistentRankingEntryProfileListener : PersistentVariableListener<RankingEntryProfileData>
	{
		[Header("Optionals")]
		[SerializeField]
		private RankingEntryProfileOptionsDataGetter optionsDataGetter;

		protected override void OnValueChanged(RankingEntryProfileData value)
		{
		}
	}
}
