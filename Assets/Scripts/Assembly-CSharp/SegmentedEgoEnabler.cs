using System.Collections.Generic;
using Crescive.Layout;
using CresciveCore;
using SegmentedOffers;
using UnityEngine;

public class SegmentedEgoEnabler : MonoBehaviour
{
	[SerializeField]
	private SimpleScrollSnapDynamicObjectsController scrollSnapDynamicObjectsController;

	[SerializeField]
	private SegmentedOfferDataService dataService;

	[SerializeField]
	private LevelSystem levelSystem;

	[SerializeField]
	private List<SegmentedOfferEgoViewController> egoViewControllers;

	private void OnEnable()
	{
	}

	private void CheckEgo(SegmentedOfferEgoViewController ego)
	{
	}
}
