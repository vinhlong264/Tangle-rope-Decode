using System.Collections.Generic;
using Crescive.Navigation;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

public class TournamentButtonController : MonoBehaviour
{
	[SerializeField]
	private GameObject buttonPivot;

	[SerializeField]
	private LayoutElement layoutElement;

	[SerializeField]
	private Canvas canvas;

	[SerializeField]
	private NavigationChannel navigationChannel;

	[SerializeField]
	private List<NavigationChannel> navigationChannelList;

	public StringConstant tutorialPanelId;

	public StringConstant tournamentPanelId;

	private readonly List<NavigationChannel> _subscribed;

	private bool _openingQueued;

	private StringConstant _pendingPanelId;

	[SerializeField]
	[Header("Tutorial")]
	private GameObject tutorialPointer;

	[SerializeField]
	private GameObject buuble;

	public static TournamentButtonController Instance;

	private Transform _bubbleOriginalParent;

	private int _bubbleOriginalSibling;

	public static bool IsTutorialShown
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public void OnButtonClicked()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnInitialize()
	{
	}

	private void UpdateButton()
	{
	}

	private void SetButtonActive(bool isActive)
	{
	}

	private bool IsEmptyOrUninitialized(NavigationChannel ch)
	{
		return false;
	}

	private IEnumerable<NavigationChannel> TargetChannels()
	{
		return null;
	}

	private bool AreAllTargetsEmpty()
	{
		return false;
	}

	private void TryOpenPanel(StringConstant panelId)
	{
	}

	private void OnAnyStackEmpty()
	{
	}

	private void CheckAndOpenIfAllEmpty()
	{
	}

	private void SubscribeAll()
	{
	}

	private void UnsubscribeAll()
	{
	}

	private void CenterOnScreen(Canvas targetCanvas)
	{
	}

	public void OnSetTournamentButtonOrder(int order)
	{
	}

	private void SetTournamentButtonOrder(int order)
	{
	}
}
