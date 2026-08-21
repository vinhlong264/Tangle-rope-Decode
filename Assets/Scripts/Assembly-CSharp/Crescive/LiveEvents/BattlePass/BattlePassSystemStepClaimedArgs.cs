namespace Crescive.LiveEvents.BattlePass
{
	public struct BattlePassSystemStepClaimedArgs
	{
		public int Step { get; }

		public bool IsGolden { get; }

		public string RewardId { get; }

		public BattlePassSystemStepClaimedArgs(int step, bool isGolden, string rewardId)
		{
			Step = 0;
			IsGolden = false;
			RewardId = null;
		}
	}
}
