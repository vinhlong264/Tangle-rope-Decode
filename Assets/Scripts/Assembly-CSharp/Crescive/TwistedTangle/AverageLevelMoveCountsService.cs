using Crescive.DataService;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[CreateAssetMenu(fileName = "AverageLevelMoveCountsService", menuName = "GameData/MoveCount/Service/AverageLevelMoveCountsService")]
	public class AverageLevelMoveCountsService : DataReadService<AverageLevelMoveCountsData>
	{
		protected override AverageLevelMoveCountsData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(AverageLevelMoveCountsData plainData)
		{
			return false;
		}

		public void AddLevels(int count)
		{
		}

		public void AddLevelsWithMoveCountFromClipboard()
		{
		}

		public void SetAllMoveCounts(int count)
		{
		}
	}
}
