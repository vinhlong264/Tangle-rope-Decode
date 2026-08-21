using ElephantSDK;
using UnityEngine.Purchasing;

public static class DirectStoreUtilities
{
	public static PurchaseFailureReason ToPurchaseFailureReason(this ElephantPaymentErrorType elephantPaymentErrorType)
	{
		return default(PurchaseFailureReason);
	}
}
