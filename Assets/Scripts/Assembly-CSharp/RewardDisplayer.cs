using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardDisplayer : MonoBehaviour
{
	public List<ItemDisplayer> ItemDisplayers;

	public Button CloseButton;

	public GameObject Main;

	private Action onClaimed;

	private RewardList rewardList;

	private float openedTime;

	private string _info;

	private void Awake()
	{
	}

	internal void DisplayRewards(RewardList rewardList, Action onClaimed, string info)
	{
	}

	private void OnCloseButtonClick()
	{
	}
}
