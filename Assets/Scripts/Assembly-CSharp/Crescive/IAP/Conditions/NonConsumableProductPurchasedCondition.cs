using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.IAP.Conditions
{
	[CreateAssetMenu(fileName = "Non Consumable Product Purchased Condition", menuName = "Crescive/IAP/Conditions/Non Consumable Product Purchased Condition")]
	public class NonConsumableProductPurchasedCondition : StringCondition
	{
		[SerializeField]
		private PersistentUserPayments persistentUserPayments;

		public override bool Call(string id)
		{
			return false;
		}
	}
}
