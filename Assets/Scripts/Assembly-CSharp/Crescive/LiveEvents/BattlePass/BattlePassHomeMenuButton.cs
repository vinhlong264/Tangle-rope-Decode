using System;
using System.Collections.Generic;
using Crescive.Sequencer;
using Crescive.Tutorials;
using CresciveCore;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.LiveEvents.BattlePass
{
	public class BattlePassHomeMenuButton : MonoBehaviour
	{
		private enum ProgressState
		{
			Default = 0,
			Open = 1,
			Finished = 2
		}

		[SerializeField]
		private TextMeshProUGUI tokenProgressText;

		[SerializeField]
		private TextMeshProUGUI claimNotificationText;

		[SerializeField]
		private Slider tokenProgressSlider;

		[SerializeField]
		private GameObject claimNotification;

		[SerializeField]
		private Image animTokenImageDefault;

		[SerializeField]
		private CanvasGroup multiplierImageCanvasGroup;

		[SerializeField]
		private Transform scalePivot;

		[SerializeField]
		private GameObject body;

		[SerializeField]
		private Button button;

		[SerializeField]
		private RectTransform tokenImage;

		[SerializeField]
		private GameObject openBGObject;

		[SerializeField]
		private GameObject openTextObject;

		[SerializeField]
		private GameObject openParticleObject;

		[SerializeField]
		private GameObject finishedTextObject;

		[SerializeField]
		private BattlePassSystem battlePassSystem;

		[SerializeField]
		private BattlePassDataService battlePassDataService;

		[SerializeField]
		private PersistentBattlePassData persistentBattlePassData;

		[SerializeField]
		private LoaderChannel loaderChannel;

		[SerializeField]
		private TutorialManagerChannel tutorialManagerChannel;

		[SerializeField]
		private List<GameObject> tutorialObjects;

		[SerializeField]
		private Canvas selfCanvas;

		[SerializeField]
		private SequenceStep claimBattlePassPendingTokensStep;

		private List<Image> animTokenImages;

		private Sequence tokenSequence;

		private Vector3 scalePivotInitialScale;

		private bool animatingTokens;

		private ProgressState progressState;

		private LayoutElement layoutElement;

		private LayoutElement LayoutElement => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnClaimBattlePassPendingTokensStepStarted(SequenceStep sequenceStep)
		{
		}

		private void LoaderOnLoadingRequested()
		{
		}

		private void TutorialStateChanged(TutorialStateChangedEvent _)
		{
		}

		private void RefreshTutorial()
		{
		}

		private void PersistentBattlePassData_OnChanged(BattlePassData _)
		{
		}

		private void Setup(BattlePassData data)
		{
		}

		private int GetClaimableStepsCount()
		{
			return 0;
		}

		private void OnPendingTokensClaimed(BattlePassSystem.PendingTokensClaimedInfo pendingInfo, Action callback)
		{
		}

		private void AnimateTokens(BattlePassData initialData, int totalEarnedCount, bool isMultiplierActive, Action callback)
		{
		}

		private void SetProgressState(BattlePassData data)
		{
		}

		private void SetProgressStateViews()
		{
		}
	}
}
