using PersistentSO;
using UnityEngine;

namespace Crescive.Scheduler
{
	[CreateAssetMenu(fileName = "Persistent Scheduler Save Data", menuName = "Crescive/Scheduler/Persistent/Persistent Scheduler Save Data")]
	public class PersistentSchedulerSaveData : PersistentVariable<SchedulerSaveData>
	{
		public override SchedulerSaveData GetCopy(SchedulerSaveData value)
		{
			return null;
		}

		public ScheduleSaveData GetScheduleSaveData(string id)
		{
			return null;
		}

		public void SetScheduleSaveData(ScheduleSaveData value)
		{
		}
	}
}
