using System.Collections.Generic;
using MyBox;
using SegmentedOffers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SegmentedOfferRewardsViewController : MonoBehaviour
{
	private const string MinutesSuffix = "m";

	private const string HoursSuffix = "h";

	[SerializeField]
	[Foldout("Products", false)]
	private TMP_Text mainProductText;

	[SerializeField]
	[Foldout("Products", false)]
	private Image mainProductIcon;

	[Foldout("Products", false)]
	[SerializeField]
	private TMP_Text sideProductText;

	[Foldout("Products", false)]
	[SerializeField]
	private Image sideProductIcon;

	[Foldout("Products", false)]
	[SerializeField]
	private GameObject sideProductParent;

	[SerializeField]
	[Foldout("Mini Products", false)]
	private SegmentedOfferProduct miniProductPrefab;

	[SerializeField]
	private SegmentedOfferDataService dataService;

	[SerializeField]
	[Foldout("Mini Products", false)]
	private List<GameObject> rows;

	private List<SegmentedOfferProduct> _miniProducts;

	private int _columnCount;

	private SegmentedOfferProductGiver _giver;

	public void DisplaySegmentedOfferProducts(List<SegmentedProduct> products, int goldAmount, SegmentedOfferProductGiver giver)
	{
	}

	private void SetMiniProducts(List<SegmentedProduct> products)
	{
	}

	private void SetLayoutGroup()
	{
	}

	private int GetRowIndex(int index)
	{
		return 0;
	}

	private void ClearMiniProducts()
	{
	}

	private void SetMainAndSideProduct(List<SegmentedProduct> products, int goldAmount)
	{
	}

	private bool IsTimeBasedProduct(ProductType type)
	{
		return false;
	}
}
