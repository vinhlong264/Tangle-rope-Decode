using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Ranking
{
	[DefaultExecutionOrder(1)]
	public class RankingEntryTop3Listener : MonoBehaviour
	{
		[SerializeField]
		private IntVariableInstancer rankVar;

		public UnityEvent<bool> OnInTop3;

		public UnityEvent<bool> OnNotInTop3;

		public UnityEvent<int> OnInTop3Rank;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnRankChangedCallback(int rank)
		{
		}
	}
}
