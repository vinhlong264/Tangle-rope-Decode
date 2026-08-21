using Crescive.Navigation;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.LiveEvents.BattlePass
{
	[RequireComponent(typeof(Navigatable))]
	public class BattlePassStartPanel : MonoBehaviour
	{
		[SerializeField]
		private BattlePassSystem battlePassSystem;

		[SerializeField]
		private NavigationChannel menuPopupNavigationChannel;

		[SerializeField]
		private StringConstant mainPanelId;

		private Navigatable? _navigatable;

		private Navigatable Navigatable => null;

		public void OnContinue()
		{
		}
	}
}
