using System;
using Crescive.IAP;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.LiveEvents.BattlePass
{
	public class BattlePassRewardRow : MonoBehaviour
	{
		[SerializeField]
		private ItemView freeReward;

		[SerializeField]
		private Button freeClaimButton;

		[SerializeField]
		private GameObject freeClaimVisual;

		[SerializeField]
		private GameObject freeCollectedVisual;

		[SerializeField]
		private ItemView goldenReward;

		[SerializeField]
		private Button goldenClaimButton;

		[SerializeField]
		private GameObject goldenClaimVisual;

		[SerializeField]
		private GameObject goldenLockedVisual;

		[SerializeField]
		private GameObject goldenCollectedVisual;

		[SerializeField]
		private Slider progressSlider;

		[SerializeField]
		private TextMeshProUGUI stepText;

		[SerializeField]
		private GameObject currentStepGlow;

		[SerializeField]
		private BattlePassSystem battlePassSystem;

		[SerializeField]
		private BattlePassDataService battlePassDataService;

		[SerializeField]
		private PersistentBattlePassData persistentBattlePassData;

		[SerializeField]
		private Canvas? freeRewardCanvas;

		[SerializeField]
		private Canvas? goldenRewardCanvas;

		[SerializeField]
		private ProductInfoDisplayer freeProductInfoDisplayer;

		[SerializeField]
		private ProductInfoDisplayer goldenProductInfoDisplayer;

		[SerializeField]
		private IAPDataService iapDataService;

		[SerializeField]
		private GameObject claimedGO;

		[SerializeField]
		private GameObject currentGO;

		[SerializeField]
		private GameObject afterGO;

		[SerializeField]
		private GameObject[] shines;

		private BattlePassRowData rowData;

		private RectTransform rectTransform;

		private Vector3? defaultScale;

		private Tween? scaleTween;

		private Action? overriddenOnGoldenClaimClicked;

		public Canvas? FreeRewardCanvas => null;

		public Canvas? GoldenRewardCanvas => null;

		private RectTransform RectTransform => null;

		public bool IsCurrentStep => false;

		public int StepLevel => 0;

		public Vector2 AnchoredPosition => default(Vector2);

		public Vector2 SizeDelta => default(Vector2);

		public void ScaleAnimation(float scale, float duration)
		{
		}

		public void Refresh()
		{
		}

		public void Setup(int stepIndex, Action? overriddenGoldenClaimClicked)
		{
		}

		private void UpdateUI()
		{
		}

		private void UpdateFreeUIs()
		{
		}

		private void UpdateGoldenUIs()
		{
		}

		private void UpdateProgressUIs()
		{
		}

		private void OnRewardClicked(int stepIndex, bool golden)
		{
		}

		public void OnFreeClaimClicked()
		{
		}

		public void OnGoldenClaimClicked()
		{
		}
	}
}
