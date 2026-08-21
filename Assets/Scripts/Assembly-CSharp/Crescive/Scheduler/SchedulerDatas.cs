using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Scheduler
{
	[CreateAssetMenu(menuName = "Crescive/Scheduler/Scheduler Data Providers")]
	public class SchedulerDatas : ScriptableObject
	{
		[SerializeField]
		private SchedulerDataService schedulerDataService;

		[SerializeField]
		private List<ScriptableObject> schedulerDataProviders;

		public List<ScheduleData> AllSchedules => null;

		public static SchedulerDataService Instance => null;

		public List<string> Ids => null;

		private void OnValidate()
		{
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
