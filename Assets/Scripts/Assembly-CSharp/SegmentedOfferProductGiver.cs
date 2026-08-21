using System.Collections.Generic;
using Crescive.Collection;
using Crescive.IAP;
using Crescive.ResourceSystem;
using SegmentedOffers;
using UnityEngine;

public class SegmentedOfferProductGiver : MonoBehaviour
{
	[SerializeField]
	private ResourcesChannel resourcesChannel;

	[SerializeField]
	private IAPDataService iapDataService;

	[SerializeField]
	private PersistentTemporaryProducts persistentTemporaryProducts;

	[SerializeField]
	private CollectionItemSystemsChannel collectionItemSystemsChannel;

	[SerializeField]
	private string skinId;

	public void TestButton()
	{
	}

	public void TryGiveProducts(List<SegmentedProduct> list)
	{
	}

	private void TryGiveInfHearth(SegmentedProduct segmentedProduct)
	{
	}

	private void TryGiveProduct(SegmentedProduct segmentedProduct)
	{
	}

	public bool CheckSkinUnlocked()
	{
		return false;
	}
}
