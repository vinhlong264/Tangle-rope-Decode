using UnityEngine;

namespace Crescive.Logger
{
	[DefaultExecutionOrder(-100000)]
	public class LogsDataController : MonoBehaviour
	{
		[SerializeField]
		private LogsDataChannel logsDataChannel;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Log(string logString, string stackTrace, LogType type)
		{
		}
	}
}
