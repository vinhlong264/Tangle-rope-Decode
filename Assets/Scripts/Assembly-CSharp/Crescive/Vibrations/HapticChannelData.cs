using System;

namespace Crescive.Vibrations
{
	[Serializable]
	public struct HapticChannelData
	{
		public bool Active;

		public HapticChannelData(bool active)
		{
			Active = false;
		}

		public HapticChannelData(HapticChannelData other)
		{
			Active = false;
		}
	}
}
