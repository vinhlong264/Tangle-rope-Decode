using System;
using System.Collections.Generic;

namespace Crescive.Logger
{
	[Serializable]
	public class LogsData
	{
		public List<LogData> logs;

		public LogsData()
		{
		}

		public LogsData(List<LogData> logs)
		{
		}
	}
}
