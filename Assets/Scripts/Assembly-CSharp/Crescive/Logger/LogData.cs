using System;
using UnityEngine;

namespace Crescive.Logger
{
	[Serializable]
	public class LogData
	{
		public LogType t;

		public string msg;

		public string st;

		public LogData(LogType t, string msg, string st)
		{
		}
	}
}
