using UnityAtoms;
using UnityEngine;

namespace Crescive.LiveEvents.BattlePass
{
	[CreateAssetMenu(menuName = "Crescive/BattlePass/Conditions/GoldenTicketPurchased")]
	public class BattlePassGoldenTicketPurchasedCondition : AtomCondition
	{
		[SerializeField]
		private BattlePassSystem battlePassSystem;

		public override bool Call()
		{
			return false;
		}
	}
}
