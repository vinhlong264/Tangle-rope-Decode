using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Plinko
{
	public class BallCountArea : MonoBehaviour
	{
		[SerializeField]
		private SpriteRenderer buttonVisual;

		[SerializeField]
		private Sprite normalVisual;

		[SerializeField]
		private Sprite highVisual;

		[SerializeField]
		private Color buttonAnimationColor;

		[SerializeField]
		private float animationDuration;

		[SerializeField]
		private float waitDuration;

		[SerializeField]
		private TextMeshPro ballCountText;

		[SerializeField]
		private TextMeshPro multiplierText;

		[SerializeField]
		private RewardAreaTrigger[] rewardAreaTriggers;

		private Sequence animationSequence;

		public int BallCountMultiplier { get; private set; }

		public bool IsBallProcessing { get; set; }

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnRewardAreaTriggered(PlinkoEvents.OnRewardAreaTriggered p)
		{
		}

		public void SetRewardCounts()
		{
		}

		private void OnMouseDown()
		{
		}

		private void OnButtonClicked()
		{
		}

		private int GetNextBallCountIndex()
		{
			return 0;
		}

		private int GetMaxBallCountIndex()
		{
			return 0;
		}

		internal void BallSpawned()
		{
		}

		private void SetNextMultiplier()
		{
		}

		private void PlayButtonClickAnimation()
		{
		}
	}
}
