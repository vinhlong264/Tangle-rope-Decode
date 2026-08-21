using UnityAtoms;
using UnityEngine;

namespace Crescive.LiveEvents.BattlePass
{
	[CreateAssetMenu(menuName = "Crescive/BattlePass/Conditions/IsLive")]
	public class BattlePassIsLiveCondition : AtomCondition
	{
		[SerializeField]
		private BattlePassSystem battlePassSystem;

		public override bool Call()
		{
			return false;
		}
	}
}
