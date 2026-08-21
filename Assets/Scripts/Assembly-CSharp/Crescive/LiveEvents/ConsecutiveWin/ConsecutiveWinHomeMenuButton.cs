using System;
using System.Collections.Generic;
using Crescive.LiveEvents.SuperPowerup;
using Crescive.Navigation;
using Crescive.Sequencer;
using CresciveCore;
using DG.Tweening;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.LiveEvents.ConsecutiveWin
{
	public class ConsecutiveWinHomeMenuButton : MonoBehaviour
	{
		[SerializeField]
		private PersistentConsecutiveWinSaveData PersistentConsecutiveWinData;

		[SerializeField]
		private SuperPowerupDataService ConsecutiveWinConfig;

		[SerializeField]
		private TextMeshProUGUI superPowerupProgressText;

		[SerializeField]
		private Slider superPowerupProgressSlider;

		[SerializeField]
		private Image animSuperPowerupImageDefault;

		[SerializeField]
		private Transform scalePivot;

		[SerializeField]
		private Button bodyButton;

		[SerializeField]
		private Image superPowerupImage;

		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private NavigationChannel menuPopupNavigationChannel;

		[SerializeField]
		private StringConstant superPowerupClaimRewardsPanelId;

		[SerializeField]
		private LoaderChannel loaderChannel;

		[SerializeField]
		private SequenceStep consecutiveWinCountIncreasedSequenceStep;

		[SerializeField]
		private SequenceStep consecutiveWinTutorialStep;

		[SerializeField]
		private List<GameObject> tutorialObjects;

		[SerializeField]
		private Canvas selfCanvas;

		[SerializeField]
		private GameObject activeParticle;

		[SerializeField]
		private GameObject animParticle;

		private Image animSuperPowerupImage;

		private Sequence animSequence;

		private Vector3 scalePivotInitialScale;

		private bool animatingSuperPowerup;

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

		private void OnPersistentBattlePassDataChanged(ConsecutiveWinSaveData _)
		{
		}

		private void OnSuperPowerUpTutorialStepChanged(SequenceStep _)
		{
		}

		private void Refresh()
		{
		}

		private void OnConsecutiveWinCountIncreasedSequenceStart(SequenceStep _)
		{
		}

		private void LoaderOnLoadingRequested()
		{
		}

		private void Setup(int winCount, SuperPowerupDataService config)
		{
		}

		private bool ShouldEnableButton()
		{
			return false;
		}

		private void AnimateSuperPowerup(Action callback)
		{
		}
	}
}
