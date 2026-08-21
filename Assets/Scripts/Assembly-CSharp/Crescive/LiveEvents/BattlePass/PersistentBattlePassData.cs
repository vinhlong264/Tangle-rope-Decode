using PersistentSO;

namespace Crescive.LiveEvents.BattlePass
{
	public class PersistentBattlePassData : PersistentVariable<BattlePassData>
	{
		public override BattlePassData GetCopy(BattlePassData value)
		{
			return null;
		}
	}
}
