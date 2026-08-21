using Crescive.League;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Ranking
{
	public class LeagueFinishedPopupController : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private PersistentLeagueHistoryData persistentLeagueHistoryData;

		[SerializeField]
		private PlayerRankingRewardClaimPanel rewardClaimPanel;

		[SerializeField]
		private IntConstant playerRankId;

		[Header("Variables")]
		[SerializeField]
		private IntVariableInstancer entryId;

		[SerializeField]
		private IntVariableInstancer rankVar;

		[SerializeField]
		private FloatVariableInstancer scoreVar;

		[SerializeField]
		private bool didSetData;

		[SerializeField]
		private int rank;

		[SerializeField]
		private float score;

		private void OnEnable()
		{
		}

		private void SyncStateToInstancers()
		{
		}

		public void OnShow()
		{
		}
	}
}
