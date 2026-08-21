using System.Collections.Generic;
using ElephantSocial.Model;
using Profile;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLadderBadgeController : MonoBehaviour
{
	[SerializeField]
	private TMP_Text playerNameText;

	[SerializeField]
	private TMP_Text scoreText;

	[SerializeField]
	private ProfilePictureUI profilePictureUI;

	[SerializeField]
	private List<GameObject> playerObjects;

	[SerializeField]
	private LeaderboardProfileBubbleController leaderboardProfileBubbleController;

	private BoardPlayer _playerRecord;

	[SerializeField]
	private Button prizeButton;

	public void Initialize(BoardPlayer playerRecord, int order, bool isPlayer)
	{
	}

	private void SetPlayerVisual(bool isPlayer)
	{
	}

	public void TryShowProfileBubble()
	{
	}
}
