using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Plinko
{
	public class PlinkoPopup : MonoBehaviour
	{
		[SerializeField]
		private GameObject main;

		[SerializeField]
		private Button closeButton;

		[SerializeField]
		private Button infoButton;

		[SerializeField]
		private TextMeshProUGUI currencyText;

		[SerializeField]
		private GameObject plinkoNormalContent;

		[SerializeField]
		private GameObject plinkoLastChanceContent;

		[SerializeField]
		private RectTransform[] animationRects;

		[SerializeField]
		private TextMeshProUGUI[] animationTexts;

		[SerializeField]
		private Transform floatingTicketTarget;

		private const float ANIMATION_ITEM_SCALE = 0.92929f;

		private Vector3[] defaultAnchoredPositions;

		private Sequence rewardSequence;

		[SerializeField]
		private float arcHeight;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnRewardAreaTriggered(PlinkoEvents.OnRewardAreaTriggered p)
		{
		}

		private void OnInfoButtonClicked()
		{
		}

		private void OnPlinkoTutorialStarted()
		{
		}

		private void OnCurrencyChanged()
		{
		}

		private void OnPlinkoMenuButtonClicked()
		{
		}

		private void OnCloseButtonClicked()
		{
		}
	}
}
