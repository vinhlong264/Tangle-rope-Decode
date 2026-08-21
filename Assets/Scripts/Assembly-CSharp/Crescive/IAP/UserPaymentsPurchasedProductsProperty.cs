using System.Collections.Generic;
using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.IAP
{
	[CreateAssetMenu(fileName = "User Payments Purchased Products Property", menuName = "Crescive/IAP/User Payments/Property/User Payments Purchased Products Property")]
	public class UserPaymentsPurchasedProductsProperty : ScriptableProperty<List<string>>
	{
		[SerializeField]
		private PersistentUserPayments userPayments;

		protected override List<string> GetValue()
		{
			return null;
		}
	}
}
