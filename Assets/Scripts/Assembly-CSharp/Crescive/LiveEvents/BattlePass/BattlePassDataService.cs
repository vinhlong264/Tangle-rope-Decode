using Crescive.DataService;

namespace Crescive.LiveEvents.BattlePass
{
	public class BattlePassDataService : DataReadService<BattlePassSettings>
	{
		protected override BattlePassSettings GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(BattlePassSettings plainData)
		{
			return false;
		}

		public BattlePassConfig GetConfig(string passId)
		{
			return null;
		}

		public bool HasConfig(string passId)
		{
			return false;
		}
	}
}
