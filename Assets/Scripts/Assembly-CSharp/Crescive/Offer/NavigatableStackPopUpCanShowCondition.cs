using Crescive.Navigation;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Offer
{
	[CreateAssetMenu(fileName = "Navigatable Stack Pop Up Can Show Condition", menuName = "Crescive/Offer/Conditions/Navigatable Stack Pop Up Can Show Condition")]
	public class NavigatableStackPopUpCanShowCondition : StringCondition
	{
		[SerializeField]
		private NavigationChannel offerPopupsChannel;

		public override bool Call(string offerPopupId)
		{
			return false;
		}
	}
}
