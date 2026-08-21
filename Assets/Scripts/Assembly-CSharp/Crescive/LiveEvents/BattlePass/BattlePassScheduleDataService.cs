using System.Collections.Generic;
using Crescive.DataService;
using Crescive.Scheduler;
using UnityEngine;

namespace Crescive.LiveEvents.BattlePass
{
	[CreateAssetMenu(fileName = "Battle Pass Schedule Data Service", menuName = "Crescive/BattlePass/Battle Pass Schedule Data Service")]
	public class BattlePassScheduleDataService : DataReadService<BattlePassScheduleSettings>, ISchedulerSystemDataProvider
	{
		protected override BattlePassScheduleSettings GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(BattlePassScheduleSettings plainData)
		{
			return false;
		}

		protected override void OnInitializedInternal(BattlePassScheduleSettings data)
		{
		}

		public List<ScheduleData> GetSchedules()
		{
			return null;
		}
	}
}
