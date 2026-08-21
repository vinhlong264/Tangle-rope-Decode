using TMPro;
using UnityEngine;
using UnityEngine.Purchasing;

public class DirectStoreModifyProductPrice : DirectStoreModifyTargetWithData<Product>
{
	private const string DefaultAmountText = "<size=80%>USD</size> {PRICE}";

	[SerializeField]
	private CanvasGroup referenceCanvasGroup;

	[SerializeField]
	private CanvasGroup targetCanvasGroup;

	[SerializeField]
	private TMP_Text referencePriceText;

	[SerializeField]
	private TMP_Text targetPriceText;

	protected override void ApplyModification()
	{
	}

	protected override void ApplyModification(Product arg)
	{
	}
}
