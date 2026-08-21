using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.Navigation;
using Crescive.Tutorials;
using DG.Tweening;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.LiveEvents.BattlePass
{
	[RequireComponent(typeof(Navigatable))]
	public class BattlePassMainPanel : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass72_0
		{
			public BattlePassMainPanel _003C_003E4__this;

			public bool animateLinesAtFinalPosition;

			public int currentStep;

			public Func<BattlePassRewardRow, bool> _003C_003E9__2;

			internal void _003CMoveLinesAndScrollToCurrentStepCoroutine_003Eb__0()
			{
			}

			internal void _003CMoveLinesAndScrollToCurrentStepCoroutine_003Eb__1()
			{
			}

			internal bool _003CMoveLinesAndScrollToCurrentStepCoroutine_003Eb__2(BattlePassRewardRow row)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CMoveLinesAndScrollToCurrentStepCoroutine_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BattlePassMainPanel _003C_003E4__this;

			public bool animateLinesAtFinalPosition;

			public int currentStep;

			public int totalSteps;

			private _003C_003Ec__DisplayClass72_0 _003C_003E8__1;

			public float duration;

			public float initialWaitDuration;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CMoveLinesAndScrollToCurrentStepCoroutine_003Ed__72(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private Navigatable? _navigatable;

		[SerializeField]
		private ScrollRect scrollRect;

		[SerializeField]
		private Image[] scrollRectContentImages;

		[SerializeField]
		private Image currentStepTopLine;

		[SerializeField]
		private Image currentStepBottomLine;

		[SerializeField]
		private RectTransform currentStepLinesParent;

		[SerializeField]
		private GameObject bonusCaseStepLinesObject;

		[SerializeField]
		private Button closeButton;

		private Tween? _currentStepScrollRectTween;

		private Sequence? _currentStepLinesSequence;

		private Coroutine? _currentStepScrollRectCoroutine;

		private bool m_AnimatingScroll;

		private bool m_AnimatingLines;

		[SerializeField]
		private TextMeshProUGUI tokenProgressBarText;

		[SerializeField]
		private TextMeshProUGUI tokenProgressBarCurrentStepText;

		[SerializeField]
		private Slider tokenProgressBarSlider;

		[SerializeField]
		private TextMeshProUGUI tokenProgressBonusCaseText;

		[SerializeField]
		private BattlePassRewardRow firstBattlePassRewardRow;

		[SerializeField]
		private Transform battlePassRewardRowsParent;

		[SerializeField]
		private BattlePassRewardRow battlePassRewardRowPrefab;

		[SerializeField]
		private Transform bonusCaseTransform;

		[SerializeField]
		private BattlePassSystem battlePassSystem;

		[SerializeField]
		private Slider bonusCaseSlider;

		[SerializeField]
		private TextMeshProUGUI bonusCaseProgressText;

		[SerializeField]
		private TextMeshProUGUI bonusCaseInfoText;

		[SerializeField]
		private GameObject bonusCaseLockObject;

		[SerializeField]
		private IntReference bonusCaseCoinsPerBadgeReference;

		[SerializeField]
		private IntReference bonusCaseBadgesForBonusStepReference;

		[SerializeField]
		private GameObject tokenProgressStepParentObject;

		[SerializeField]
		private GameObject tokenProgressBonusCaseParentObject;

		[SerializeField]
		private GameObject tokenProgressFinishedTextObject;

		[SerializeField]
		private GameObject tokenProgressStepCheckObject;

		[SerializeField]
		private GameObject goldenTicketActivateObjectsParent;

		[SerializeField]
		private GameObject goldenTicketActiveObjectsParent;

		[SerializeField]
		private NavigationChannel menuPopupNavigationChannel;

		[SerializeField]
		private StringConstant goldenTicketBuyPanelId;

		[SerializeField]
		private StringConstant goldenTicketPurchasedPanelId;

		[SerializeField]
		private StringConstant goldenTicketClaimRewardsPanelId;

		[SerializeField]
		private StringConstant battlePassInfoPanelId;

		[SerializeField]
		private GameObject claimFirstRewardTutorial;

		[SerializeField]
		private GameObject seeProgressTutorial;

		[SerializeField]
		private GameObject seeGoldenTicketTutorial;

		[SerializeField]
		private TutorialManagerChannel tutorialManagerChannel;

		[SerializeField]
		private Canvas progressBarCanvas;

		private List<BattlePassRewardRow> _rewardRows;

		private Navigatable Navigatable => null;

		private bool AnimatingScroll
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool AnimatingLines
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTutorialStateChanged(TutorialStateChangedEvent e)
		{
		}

		private void RefreshTutorialPanels()
		{
		}

		public void OnProgressClick()
		{
		}

		private void OnBattlePassDataChanged(BattlePassData battlePassData)
		{
		}

		private void ResetViews()
		{
		}

		public void Setup()
		{
		}

		private void HandleTutorialScrollAnimation()
		{
		}

		private BattlePassConfig? GetPass()
		{
			return null;
		}

		public void OpenGoldenTicketPanelWithActivationCheck()
		{
		}

		private void SetupGoldenTicketViews()
		{
		}

		private void SetupCurrentLines()
		{
		}

		private void MoveToStep(int currentStep, int lastOpenedStep, bool animate, bool animateLinesAtFinalPosition, float initialWaitDuration)
		{
		}

		private void MoveStepLinesParentToCurrentStep(int currentStep)
		{
		}

		private void AnimateCurrentStepLines(float endValue, float delay, float duration, TweenCallback? onComplete = null)
		{
		}

		private void ResetCurrentStepLinesScale()
		{
		}

		private void HandleHidingStepLines()
		{
		}

		private void MoveLinesAndScrollToCurrentStep(int currentStep, int totalSteps, float duration, bool animateLinesAtFinalPosition, float initialWaitDuration)
		{
		}

		[IteratorStateMachine(typeof(_003CMoveLinesAndScrollToCurrentStepCoroutine_003Ed__72))]
		private IEnumerator MoveLinesAndScrollToCurrentStepCoroutine(int currentStep, int totalSteps, float duration, bool animateLinesAtFinalPosition, float initialWaitDuration)
		{
			return null;
		}

		private void SetupTokenProgressBar()
		{
		}

		private void SetupRewardRows()
		{
		}

		private void RefreshRewardRows()
		{
		}

		private void SetupBonusCase()
		{
		}
	}
}
