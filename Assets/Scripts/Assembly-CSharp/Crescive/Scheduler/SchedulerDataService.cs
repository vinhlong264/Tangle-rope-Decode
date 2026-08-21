using System.Collections.Generic;
using Crescive.DataService;
using UnityEngine;

namespace Crescive.Scheduler
{
	[CreateAssetMenu(fileName = "Scheduler Data Service", menuName = "Crescive/Scheduler/Service/Scheduler Data Service")]
	public class SchedulerDataService : DataReadService<SchedulerData>
	{
		public static SchedulerDataService Instance => null;

		public List<string> Ids => null;

		protected override SchedulerData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(SchedulerData plainData)
		{
			return false;
		}

		protected override SchedulerData PreProcessData(SchedulerData plainData)
		{
			return null;
		}

		public ScheduleData GetScheduleData(string id)
		{
			return null;
		}

		public ScheduleData GetScheduleDataWithItem(string itemId)
		{
			return null;
		}

		public List<string> GetAllItemIds(bool addEmpty = true)
		{
			return null;
		}
	}
}
