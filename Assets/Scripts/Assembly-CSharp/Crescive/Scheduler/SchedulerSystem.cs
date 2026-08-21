using System;
using System.Collections.Generic;
using CresciveCore;
using UnityEngine;

namespace Crescive.Scheduler
{
	[CreateAssetMenu(fileName = "Scheduler System", menuName = "Crescive/Scheduler/System/Scheduler System")]
	public class SchedulerSystem : ScriptableObject
	{
		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private SchedulerDatas dataService;

		[SerializeField]
		private PersistentSchedulerSaveData saveData;

		[SerializeField]
		private SchedulerEvents events;

		public LevelSystem LevelSystem => null;

		public SchedulerDatas DataService => null;

		public PersistentSchedulerSaveData SaveData => null;

		public SchedulerEvents Events => null;

		private void SaveScheduleActivation(ScheduleData scheduleData)
		{
		}

		public bool IsInSchedule(ScheduleData scheduleData)
		{
			return false;
		}

		public void GetWeeklyStartEndTimeDates(ScheduleData scheduleData, out DateTime startTimeDate, out DateTime endTimeDate)
		{
			startTimeDate = default(DateTime);
			endTimeDate = default(DateTime);
		}

		public void GetDateStartEndTimeDates(ScheduleData scheduleData, out DateTime startTimeDate, out DateTime endTimeDate)
		{
			startTimeDate = default(DateTime);
			endTimeDate = default(DateTime);
		}

		public void GetMonthlyStartEndTimeDates(ScheduleData scheduleData, out DateTime startTimeDate, out DateTime endTimeDate)
		{
			startTimeDate = default(DateTime);
			endTimeDate = default(DateTime);
		}

		public void GetStartEndTimeDates(ScheduleData scheduleData, out DateTime startTimeDate, out DateTime endTimeDate)
		{
			startTimeDate = default(DateTime);
			endTimeDate = default(DateTime);
		}

		public List<string> GetOneByOneActiveItemIds(ScheduleSaveData scheduleSaveData, ScheduleData scheduleData)
		{
			return null;
		}

		public List<string> GetAllActiveItemIds(ScheduleData scheduleData)
		{
			return null;
		}

		private bool IsScheduleStarted(string id)
		{
			return false;
		}

		private bool IsScheduleStarted(ScheduleData scheduleData)
		{
			return false;
		}

		private bool IsScheduleActive(string id)
		{
			return false;
		}

		private bool IsScheduleActive(ScheduleData scheduleData)
		{
			return false;
		}

		private bool IsScheduleStartedNotActive(string id)
		{
			return false;
		}

		private bool IsScheduleStartedNotActive(ScheduleData scheduleData)
		{
			return false;
		}

		public IEnumerable<ScheduleData> GetSchedules()
		{
			return null;
		}

		public IEnumerable<ScheduleData> GetAvailableSchedules()
		{
			return null;
		}

		public IEnumerable<ScheduleData> GetStartedNotActiveSchedules()
		{
			return null;
		}

		public IEnumerable<ScheduleData> GetAllStartedSchedules()
		{
			return null;
		}

		public IEnumerable<ScheduleData> GetActiveSchedules()
		{
			return null;
		}

		public IEnumerable<string> GetActiveScheduleItemIds()
		{
			return null;
		}

		public IEnumerable<string> GetActiveScheduleItemIds(out List<ScheduleData> activeSchedules)
		{
			activeSchedules = null;
			return null;
		}

		public bool IsScheduleItemActive(string scheduleItemId)
		{
			return false;
		}

		public bool IsScheduleItemActive(string scheduleItemId, out ScheduleData activeSchedule)
		{
			activeSchedule = null;
			return false;
		}

		public bool IsInSchedule(string id)
		{
			return false;
		}

		public void GetStartEndTimeDates(string id, out DateTime startTimeDate, out DateTime endTimeDate)
		{
			startTimeDate = default(DateTime);
			endTimeDate = default(DateTime);
		}

		public ScheduleData GetScheduleData(string id)
		{
			return null;
		}

		public ScheduleData GetScheduleDataWithItem(string itemId)
		{
			return null;
		}

		public ScheduleSaveData GetScheduleSaveData(string id)
		{
			return null;
		}

		public ScheduleSaveData GetScheduleSaveData(ScheduleData data)
		{
			return null;
		}

		public bool HasSchedule(string id)
		{
			return false;
		}

		public bool HasScheduleWithItem(string itemId)
		{
			return false;
		}

		public bool IsScheduleEnabled(string id)
		{
			return false;
		}

		public bool IsScheduleWithItemEnabled(string itemId)
		{
			return false;
		}

		public void StartSchedule(ScheduleData scheduleData, bool activateNow = false)
		{
		}

		public void ActivateStartedSchedule(string scheduleId)
		{
		}

		public void ExpireSchedule(ScheduleExpirationData scheduleExpirationData)
		{
		}
	}
}
