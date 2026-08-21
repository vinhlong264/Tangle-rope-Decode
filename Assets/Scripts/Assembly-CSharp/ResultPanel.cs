using System;
using System.Collections.Generic;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResultPanel : MonoBehaviour
{
	[Header("Root")]
	[SerializeField]
	private GameObject claimObject;

	[Header("Buttons")]
	[SerializeField]
	private Button claimButton;

	[SerializeField]
	private Button continueButton;

	[SerializeField]
	private GameObject closeButton;

	[SerializeField]
	[Header("Texts")]
	private GameObject timeTextObject;

	[SerializeField]
	private GameObject finishedTextObject;

	[SerializeField]
	private GameObject claimTextObject;

	[SerializeField]
	private GameObject continueTextObject;

	[SerializeField]
	private TMP_Text claimText;

	[SerializeField]
	private TMP_FontAsset japonFont;

	[SerializeField]
	private TMP_FontAsset normalFont;

	[Header("Rewards")]
	[SerializeField]
	private TournamentProductGiver giver;

	[SerializeField]
	private List<SkeletonDataAsset> chest;

	public void Show(TournamentResultPayload payload, List<TournamentPrize> prizes, Action onClaimOk, Action onContinueOk, Action<string> onError, Action requestRefresh)
	{
	}

	public void Hide()
	{
	}

	private void SetFinishedVisual(bool isFinished)
	{
	}
}
