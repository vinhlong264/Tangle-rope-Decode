using System;
using System.Collections.Generic;
using CresciveCore;
using SegmentedOffers;
using UnityEngine;

public class SegmentedOffersStoreViewController : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> segmentedOffersObjects;

	[SerializeField]
	private List<SegmentedOfferStoreViewController> storeViewControllers;

	[SerializeField]
	private SegmentedOfferDataService dataService;

	[SerializeField]
	private LevelSystem levelSystem;

	private void OnEnable()
	{
	}

	private void Setup()
	{
	}

	private void OnStoreViewControllerStateChanged(bool obj)
	{
	}

	private void CheckHeaderView()
	{
	}

	private void CheckOfferTime(SegmentSettings offer, SegmentedOfferStoreViewController storeViewController)
	{
	}

	private void SetStoreViewController(SegmentedOfferStoreViewController storeView, bool isActive)
	{
	}

	private DateTime UnixToDateTime(long unixSeconds)
	{
		return default(DateTime);
	}
}
