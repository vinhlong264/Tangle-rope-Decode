using Crescive.IAP;
using UnityEngine;

namespace Crescive.LiveEvents.BattlePass
{
	public class BattlePassGoldenTicketProductIdSetter : MonoBehaviour
	{
		[SerializeField]
		private BattlePassSystem battlePassSystem;

		[SerializeField]
		private IAPProductListener iapProductListener;

		public void OnEnable()
		{
		}
	}
}
