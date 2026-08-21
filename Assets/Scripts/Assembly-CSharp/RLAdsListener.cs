using RollicGames.Advertisements;
using UnityEngine;
using UnityEngine.Events;

public class RLAdsListener : MonoBehaviour
{
	public UnityEvent OnRewardedAdFinished;

	public UnityEvent OnRewardedAdSkipped;

	public UnityEvent OnRewardedAdFailed;

	private RLAdvertisementManager AdManager => null;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void RewardedAdResultCallback(RLRewardedAdResult obj)
	{
	}
}
