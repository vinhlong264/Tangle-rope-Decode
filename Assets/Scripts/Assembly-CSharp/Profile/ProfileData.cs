using System;
using Stats;

namespace Profile
{
	[Serializable]
	public class ProfileData
	{
		public string PlayerName;

		public StatDatas StatDatas;

		public DateTime PlayingSince;

		public int ProfilePictureIndex;

		public int ProfileFrameIndex;

		public int level;

		public long scoreUpdateTime;

		public ProfileData()
		{
		}

		public ProfileData(ProfileData p)
		{
		}
	}
}
