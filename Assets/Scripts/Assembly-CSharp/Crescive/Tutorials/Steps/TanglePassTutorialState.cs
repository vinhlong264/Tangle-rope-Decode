namespace Crescive.Tutorials.Steps
{
	public struct TanglePassTutorialState : ITutorialState
	{
		public enum StateEnum
		{
			OpenBattlePassPanel = 0,
			ClaimFirstReward = 1,
			SeeProgress = 2,
			SeeGoldenTicket = 3
		}

		public StateEnum State;
	}
}
