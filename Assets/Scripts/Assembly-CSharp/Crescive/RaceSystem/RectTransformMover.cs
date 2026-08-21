using DG.Tweening;
using UnityEngine;

namespace Crescive.RaceSystem
{
	[DefaultExecutionOrder(-100)]
	public class RectTransformMover : MonoBehaviour
	{
		[SerializeField]
		private RectTransform rectTransform;

		[SerializeField]
		private float moveDuration;

		[SerializeField]
		private Ease moveEase;

		private Transform originalParent;

		private void Awake()
		{
		}

		public void MoveToTarget(RectTransform target, bool immediate)
		{
		}

		public void MoveBack(bool immediate)
		{
		}
	}
}
