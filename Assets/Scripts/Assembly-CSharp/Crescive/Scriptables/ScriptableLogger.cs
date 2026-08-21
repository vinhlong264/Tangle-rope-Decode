using UnityEngine;

namespace Crescive.Scriptables
{
	[CreateAssetMenu(fileName = "Scriptable Logger", menuName = "Crescive/Scriptables/Logger/Scriptable Logger")]
	public class ScriptableLogger : ScriptableObject
	{
		[SerializeField]
		private bool enabled;

		[SerializeField]
		private LogType logType;

		[SerializeField]
		private Color logColor;

		public void Log(string message)
		{
		}
	}
}
