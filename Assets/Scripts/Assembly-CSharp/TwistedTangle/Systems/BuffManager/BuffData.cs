using System;

namespace TwistedTangle.Systems.BuffManager
{
	[Serializable]
	public class BuffData
	{
		public BuffType buffType;

		public DateTime endTime;

		public BuffData(BuffType type, DateTime end)
		{
		}
	}
}
