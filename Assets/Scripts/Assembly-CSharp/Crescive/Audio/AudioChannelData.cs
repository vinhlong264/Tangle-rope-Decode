using System;

namespace Crescive.Audio
{
	[Serializable]
	public struct AudioChannelData
	{
		public bool Active;

		public float Volume;

		public AudioChannelData(bool active, float volume)
		{
			Active = false;
			Volume = 0f;
		}

		public AudioChannelData(AudioChannelData other)
		{
			Active = false;
			Volume = 0f;
		}
	}
}
