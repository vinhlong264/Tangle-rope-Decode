using System.Collections.Generic;
using MyBox;
using Tournaments;
using UnityEngine;
using UnityEngine.UI;

public class TournamentPrizeViewer : MonoBehaviour
{
	[SerializeField]
	[Foldout("Products", false)]
	private GameObject sideProductParent;

	[SerializeField]
	private TournamentsDataService dataService;

	[SerializeField]
	private GridLayoutGroup groupLayout;

	[SerializeField]
	[Foldout("Mini Products", false)]
	private SegmentedOfferProduct miniProductPrefab;

	private List<GameObject> prizeGo;

	public void SetPrize(int place)
	{
	}

	private void OnDisable()
	{
	}

	private void ClearPrize()
	{
	}
}
