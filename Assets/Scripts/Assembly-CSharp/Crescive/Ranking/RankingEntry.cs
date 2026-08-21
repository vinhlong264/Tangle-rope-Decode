using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Ranking
{
	[DefaultExecutionOrder(1)]
	public class RankingEntry : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private RankingEntryRewardPanel rewardPanel;

		[Header("Variables")]
		[SerializeField]
		private IntVariableInstancer entryIdVar;

		[SerializeField]
		private IntVariableInstancer rankVar;

		[SerializeField]
		private FloatVariableInstancer scoreVar;

		[SerializeField]
		private StringVariableInstancer playerNameVar;

		[SerializeField]
		private IntVariableInstancer iconIdVar;

		[SerializeField]
		private IntVariableInstancer iconColorIdVar;

		[SerializeField]
		private bool didSetData;

		[SerializeField]
		private int rank;

		[SerializeField]
		private RankingEntryData currentData;

		[SerializeField]
		private RankingEntryProfileData currentProfileData;

		public UnityEvent OnDataSet;

		public int Rank => 0;

		public int Id => 0;

		public RankingEntryData CurrentData => null;

		public RankingEntryProfileData CurrentProfileData => null;

		private void OnEnable()
		{
		}

		private void SyncStateToInstancers()
		{
		}

		public void SetData(int entryRank, RankingEntryData data, RankingEntryProfileData profileData, RankingRewardData rewardData = null)
		{
		}
	}
}
