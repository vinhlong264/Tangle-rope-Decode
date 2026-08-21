using System.Collections.Generic;
using Crescive.IAP;
using Crescive.Scriptables;
using UnityEngine;

public class Helper : MonoBehaviour
{
	public static bool IsInGame;

	public ScriptableAction ClaimNoAdsPurchase;

	[SerializeField]
	private IAPDataService dataService;

	[SerializeField]
	protected string productId;

	private List<string> ProductIds => null;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnLevelCreated()
	{
	}

	private void OnReturnedHome()
	{
	}

	private void CheckNoAdsStoraAvailablity()
	{
	}
}
