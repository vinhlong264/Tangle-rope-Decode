using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Logger
{
	[CreateAssetMenu(fileName = "LogsDataChannel", menuName = "Crescive/Logs/LogsDataChannel")]
	public class LogsDataChannel : ScriptableObject
	{
		[SerializeField]
		private int logLimit;

		[SerializeField]
		private List<LogType> logTypesToInclude;

		[SerializeField]
		private LogsData logsData;

		public void ResetData()
		{
		}

		public LogsData GetLogs()
		{
			return null;
		}

		public void AddLog(LogData logData)
		{
		}

		public void ClearLogs()
		{
		}
	}
}
