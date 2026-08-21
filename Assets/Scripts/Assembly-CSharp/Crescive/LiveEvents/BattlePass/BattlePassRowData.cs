namespace Crescive.LiveEvents.BattlePass
{
	public class BattlePassRowData
	{
		public string? FreeRewardInfo;

		public string? GoldenRewardInfo;

		public bool IsFreeRewardClaimed;

		public bool IsGoldenRewardClaimed;

		public bool IsCompleted;

		public bool IsGoldenActive;

		public bool IsCurrentStep;

		public int StepLevel;

		public BattlePassRowData(string? freeRewardInfo, string? goldenRewardInfo, bool isFreeRewardClaimed, bool isGoldenRewardClaimed, bool isCompleted, bool isGoldenActive, bool isCurrentStep, int stepLevel)
		{
		}
	}
}
