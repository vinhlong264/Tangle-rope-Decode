using RSG;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class AverageLevelMoveCountRequester : MonoBehaviour
	{
		[SerializeField]
		private LevelsMoveCountSettingsService levelsMoveCountSettingsService;

		[SerializeField]
		private AverageLevelMoveCountsService avgMoveCountsService;

		[SerializeField]
		private bool requestOnEnable;

		public UnityEvent<int> OnGetAvgMoveCount;

		private void OnEnable()
		{
		}

		private void RequestData()
		{
		}

		private void OnGetAllData(Tuple<LevelsMoveCountSettings, AverageLevelMoveCountsData> tuple)
		{
		}
	}
}
