using ElephantSocial.Model;
using Profile;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLadderCardController : MonoBehaviour
{
	[SerializeField]
	private TMP_Text orderText;

	[SerializeField]
	private TMP_Text playerNameText;

	[SerializeField]
	private TMP_Text scoreText;

	[SerializeField]
	private Image bgImage;

	[SerializeField]
	private ProfilePictureUI profilePictureUI;

	[SerializeField]
	private Sprite normalBackground;

	[SerializeField]
	private LeaderboardProfileBubbleController leaderboardProfileBubbleController;

	[SerializeField]
	private Sprite userBackground;

	[SerializeField]
	private TMP_Text scoreHeader;

	[SerializeField]
	private Color playerScoreColor;

	[SerializeField]
	private Color otherPlayerScoreColor;

	[SerializeField]
	private Image seperatorImage;

	[SerializeField]
	private Sprite playerSeperatorSprite;

	[SerializeField]
	private Sprite otherPlayerSeperatorSprite;

	private bool _isUpdateOrder;

	private BoardPlayer _playerRecord;

	private int Order
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public void SetOrder(int order)
	{
	}

	private void FixedUpdate()
	{
	}

	public void Initialize(BoardPlayer playerRecord, int order, bool isPlayer)
	{
	}

	public void SetOrderAnimation(int oldOrder, int newOrder, float moveDur)
	{
	}

	public void SetScoreText(int playerRecordScore, bool withAnimation = false, float time = 0.5f)
	{
	}

	private void SetPlayerVisual(bool isPlayer)
	{
	}

	public void SetActiveLadder(bool isActive)
	{
	}

	public void TryShowProfileBubble()
	{
	}
}
