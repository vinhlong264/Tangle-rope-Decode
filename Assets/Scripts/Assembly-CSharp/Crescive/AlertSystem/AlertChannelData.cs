using System;

namespace Crescive.AlertSystem
{
	[Serializable]
	public class AlertChannelData
	{
		public bool Active;

		public string Text;

		public AlertChannelData(bool active, string text)
		{
		}

		public AlertChannelData(AlertChannelData other)
		{
		}
	}
}
