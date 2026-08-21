using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KittyLaneController : KittyController
{
	[SerializeField]
	[Header("Name & Tags")]
	private TMP_Text nameText;

	[SerializeField]
	private Image nameTagImage;

	[SerializeField]
	private Sprite playerNameTagSprite;

	[SerializeField]
	private Sprite opponentNameTagSprite;

	[SerializeField]
	[Header("Background")]
	private Image bgImage;

	[SerializeField]
	private Color playerBgSprite;

	[SerializeField]
	private Color opponentBgSprite;

	[SerializeField]
	[Header("Prize")]
	private Button badgeButton;

	[SerializeField]
	private TMP_Text prizeText;

	[SerializeField]
	private GameObject prizeParent;

	[SerializeField]
	private Image prizeIcon;

	[SerializeField]
	[Header("Claim Chest")]
	private Button claimButton;

	[SerializeField]
	private List<Sprite> chest;

	[SerializeField]
	private Image chestImage;

	private void Update()
	{
	}

	public override void Initialize(bool isPlayerKitty, int place = 0, int point = 0, List<float> settingsCoinRewards = null)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnClickBadge()
	{
	}

	public void OpenClaimButton(int rank, Action onClickedButton = null)
	{
	}
}
