using Crescive.Navigation;
using ElephantSocial.Model;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardProfileBubbleController : MonoBehaviour
{
	[Header("Profile Bubble")]
	[SerializeField]
	private GameObject uiObjectParent;

	[SerializeField]
	private Button viewProfileUpperButton;

	[SerializeField]
	private Button viewProfileLowerButton;

	[Header("Prize Info Bubble (new)")]
	[SerializeField]
	private TournamentPrizeViewer prizeUiObjectParent;

	[SerializeField]
	[Header("Navigation")]
	private NavigationChannel menuPopupNavigationChannel;

	[SerializeField]
	private StringConstant profileMainPanelId;

	public bool isBubbleEnabled;

	private BoardPlayer _currentPlayer;

	private RectTransform _profileAnchorRect;

	private RectTransform _prizeAnchorRect;

	private bool _openedThisFrame;

	private void Update()
	{
	}

	private bool IsPointerOverUiPrefabHierarchy(Vector2 screenPos, GameObject parent)
	{
		return false;
	}

	private bool IsPointerOverRect(RectTransform rect, Vector2 screenPos)
	{
		return false;
	}

	private void SetProfileActivated(bool activated)
	{
	}

	private void OnClickViewProfileButton()
	{
	}

	public void TryShowProfileBubble(BoardPlayer boardPlayer, RectTransform rect)
	{
	}

	private Button ChooseButtonByScreenY()
	{
		return null;
	}

	private void SetPrizeActivated(bool activated)
	{
	}

	public void TryShowPrizeInfo(int place, RectTransform rect)
	{
	}
}
