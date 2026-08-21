using Crescive.Ranking;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class PlayerRankSetter : MonoBehaviour
	{
		[SerializeField]
		private PersistentRankingEntries rankingEntries;

		[SerializeField]
		private IntReference playerId;

		public void SetPlayerRankingScore(int score)
		{
		}
	}
}
