using System.Collections.Generic;
using ElephantSocial.Model;
using Profile;
using TMPro;
using UnityEngine;

public class PlayerLadderLevelEndBadgeController : MonoBehaviour
{
	[SerializeField]
	private TMP_Text playerNameText;

	[SerializeField]
	private TMP_Text scoreText;

	[SerializeField]
	private ProfilePictureUI profilePictureUI;

	[SerializeField]
	private List<GameObject> playerObjects;

	private BoardPlayer _playerRecord;

	public void Initialize(BoardPlayer playerRecord, int order, bool isPlayer)
	{
	}

	private void SetPlayerVisual(bool isPlayer)
	{
	}

	public void SetActiveLadder(bool b)
	{
	}
}
