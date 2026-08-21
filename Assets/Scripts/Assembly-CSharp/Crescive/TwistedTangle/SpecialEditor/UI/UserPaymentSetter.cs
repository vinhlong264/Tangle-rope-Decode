using Crescive.IAP;
using TMPro;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor.UI
{
	public class UserPaymentSetter : MonoBehaviour
	{
		[SerializeField]
		private PersistentUserPayments persistentUserPayments;

		[SerializeField]
		private TextMeshProUGUI totalSpentText;

		[SerializeField]
		private TextMeshProUGUI totalPurchaseCountText;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetTexts()
		{
		}

		private void SetTexts(UserPaymentData paymentData)
		{
		}

		private void SetTotalSpentText(float totalSpent)
		{
		}

		private void SetTotalPurchaseCountText(int totalPurchaseCount)
		{
		}
	}
}
