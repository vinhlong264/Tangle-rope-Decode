using System;
using System.Runtime.CompilerServices;
using RollicGames.Advertisements;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class RewardedButtonHelper : MonoBehaviour
{
	public static string ActiveRewardedVideoIdKey;

	public string rewardedVideoId;

	public UnityEvent<int> OnRewardedSuccessful;

	public Button[] disableButtonListIfPressedShowRewardedVideo;

	private Button _button;

	private bool _rewardedRequested;

	[SerializeField]
	private TMP_Text rewardedCountText;

	private const string RewardedTextBase = "Get x{AMOUNT} Free";

	public static bool IsSystemEnabled => false;

	public static string PlayerPrefsOverrideKey => null;

	public int RewardedBoosterCount => 0;

	private static int RewardedBoosterDailyRemoteCount => 0;

	public static int RewardedBoosterDailyCount
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	private static int DayNumber
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static event Action OnRewardedVideoDailyCountOver
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private static void CheckNewDay()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnButtonClick()
	{
	}

	private void OnRewardedSuccessfulEvent(RLRewardedAdResult obj)
	{
	}

	private static void CheckButtonStatus()
	{
	}

	private void HideButton()
	{
	}

	public static bool CheckActive()
	{
		return false;
	}
}
