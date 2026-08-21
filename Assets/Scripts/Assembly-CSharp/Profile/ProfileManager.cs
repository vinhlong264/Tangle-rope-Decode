using Stats;
using UnityEngine;

namespace Profile
{
	[DefaultExecutionOrder(int.MinValue)]
	public class ProfileManager : MonoBehaviour
	{
		public static ProfileManager Instance;

		private ProfileData profileData;

		public static ProfileData ProfileData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void SetProfileData(ProfileData profileData)
		{
		}

		public void SetProfileStats(StatDatas stats)
		{
		}
	}
}
