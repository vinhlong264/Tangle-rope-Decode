using UnityAtoms;
using UnityEngine;

namespace Crescive.PopUps
{
	[CreateAssetMenu(fileName = "Offer Pop Up Level Settings Condition", menuName = "Crescive/Pop Ups/Conditions/Offer Pop Up Level Settings Condition")]
	public class OfferPopUpLevelSettingsCondition : AtomCondition
	{
		[SerializeField]
		private OfferPopUpLevelSettingsDataService service;

		public override bool Call()
		{
			return false;
		}
	}
}
