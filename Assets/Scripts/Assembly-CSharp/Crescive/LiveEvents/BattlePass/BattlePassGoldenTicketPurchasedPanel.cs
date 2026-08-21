using Crescive.Navigation;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.LiveEvents.BattlePass
{
	[RequireComponent(typeof(Navigatable))]
	public class BattlePassGoldenTicketPurchasedPanel : MonoBehaviour
	{
		[SerializeField]
		private BattlePassSystem battlePassSystem;

		[SerializeField]
		private NavigationChannel menuPopupNavigationChannel;

		[SerializeField]
		private StringConstant goldenTicketClaimRewardsPanelId;

		private Navigatable? _navigatable;

		private Navigatable Navigatable => null;

		public void OnContinue()
		{
		}
	}
}
