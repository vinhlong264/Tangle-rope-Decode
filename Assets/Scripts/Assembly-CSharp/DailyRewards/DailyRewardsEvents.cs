using System.Runtime.InteropServices;

namespace DailyRewards
{
	public class DailyRewardsEvents
	{
		public struct OnDayClaimed : IEvent
		{
			public int dayIndex;

			public OnDayClaimed(int dayIndex)
			{
				this.dayIndex = 0;
			}
		}

		public struct OnMonthlyProgressionClaimed : IEvent
		{
			public int rewardIndex;

			public OnMonthlyProgressionClaimed(int rewardIndex)
			{
				this.rewardIndex = 0;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnTutorialCompleted : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnDailyRewardsMenuButtonClicked : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnUpdateDailyRewardsMenuButtonUI : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnDayMissed : IEvent
		{
		}
	}
}
