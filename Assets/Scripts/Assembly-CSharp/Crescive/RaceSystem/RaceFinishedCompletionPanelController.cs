using System.Collections.Generic;
using DG.Tweening;
using Spine.Unity;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Crescive.RaceSystem
{
	public class RaceFinishedCompletionPanelController : MonoBehaviour
	{
		private enum PanelState
		{
			Waiting = 0,
			WaitingForClaim = 1,
			WaitingForClose = 2
		}

		[SerializeField]
		private Transform rewardPanel;

		[SerializeField]
		private Transform losePanel;

		[SerializeField]
		private TMP_Text rankText;

		[SerializeField]
		private Sprite[] rankSprites;

		[SerializeField]
		private Image rankImage;

		[SerializeField]
		private Button panelButton;

		[SerializeField]
		private TMP_Text claimText;

		[SerializeField]
		private TMP_Text closeText;

		[SerializeField]
		private GameObject content;

		[SerializeField]
		public UnityEvent TapToContinueEvent;

		public UnityEvent ClaimRewardEvent;

		[SerializeField]
		[Header("Spine")]
		private SkeletonGraphic spine;

		[Header("Spine")]
		[SerializeField]
		private List<SkeletonDataAsset> chests;

		[SpineAnimation(null, "skeletonDataAsset", true, false, false)]
		public string idleAnimation;

		[SpineAnimation(null, "skeletonDataAsset", true, false, false)]
		public string actionAnimation;

		[SerializeField]
		private Transform glowImage;

		[SerializeField]
		private Transform prizeImage;

		[SerializeField]
		private List<Transform> path;

		[SerializeField]
		private GameObject rewardText;

		[SerializeField]
		private FloatVariableInstancer floatVariable;

		private PanelState _state;

		private bool _chestOpening;

		private Sequence _sequence;

		private Tween _claimDelayTween;

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		public void SetRank(int rank)
		{
		}

		private void SetSpine(int rank)
		{
		}

		private void OnClick()
		{
		}

		private void OpenChest()
		{
		}

		private void SkipToClaim()
		{
		}

		private void ClosePanel()
		{
		}

		private void SetVisual(int rank)
		{
		}

		private void PlayActionThenIdle()
		{
		}

		private void SafeKillTweens()
		{
		}
	}
}
