using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.IAP
{
	[CreateAssetMenu(fileName = "User Payments Total Payment Property", menuName = "Crescive/IAP/User Payments/Property/User Payments Total Payment Property")]
	public class UserPaymentsTotalPaymentProperty : FloatScriptableProperty
	{
		[SerializeField]
		private PersistentUserPayments userPayments;

		protected override float GetValue()
		{
			return 0f;
		}
	}
}
