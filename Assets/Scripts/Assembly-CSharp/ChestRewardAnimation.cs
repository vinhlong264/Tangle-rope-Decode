using System;
using System.Collections.Generic;
using DG.Tweening;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChestRewardAnimation : MonoBehaviour
{
	public SkeletonGraphic spine;

	public RectTransform prizePivot;

	public GameObject main;

	[SerializeField]
	private List<SkeletonDataAsset> convertFrom;

	[SerializeField]
	private List<SkeletonDataAsset> convertTo;

	[SerializeField]
	private List<Transform> path;

	[SerializeField]
	private List<ItemDisplayer> itemDisplayers;

	[SerializeField]
	private Transform glowImage;

	[SerializeField]
	private string idleAnimation;

	[SerializeField]
	private string actionAnimation;

	[SerializeField]
	private Button panelButton;

	[SerializeField]
	private GameObject claimText;

	[SerializeField]
	private TMP_Text headerText;

	private bool isReadyForClaim;

	private Action onComplete;

	private Sequence sequence;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnChestRewardAnimation(GameEvents.OnChestRewardAnimation payload)
	{
	}

	private void OnCloseButtonClicked()
	{
	}

	private void Skip()
	{
	}

	private void OpenChest(SkeletonDataAsset skeletonDataAsset, RewardList rewardList, Action onComplete)
	{
	}

	private void PlayActionThenIdle()
	{
	}
}
