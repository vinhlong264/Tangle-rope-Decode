using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Plinko
{
	public class RewardAreaTrigger : MonoBehaviour
	{
		public int TriggerAreaID;

		[SerializeField]
		private SpriteRenderer visual;

		[SerializeField]
		private Color animationColor;

		[SerializeField]
		private float animationDuration;

		[SerializeField]
		private float waitDuration;

		[SerializeField]
		private TextMeshPro rewardAmountText;

		private const string PLAYER_TAG = "Player";

		private Sequence animationSequence;

		private bool isSimulation;

		public int TriggerCount { get; private set; }

		public int RewardCount { get; private set; }

		private void OnTriggerEnter2D(Collider2D collision)
		{
		}

		private void PlayOnBallEnteredAnimation()
		{
		}

		public void SetRewardCount(int rewardCount)
		{
		}

		public void SetIsSimulation(bool isSimulation)
		{
		}

		public void ResetTriggerCount()
		{
		}
	}
}
