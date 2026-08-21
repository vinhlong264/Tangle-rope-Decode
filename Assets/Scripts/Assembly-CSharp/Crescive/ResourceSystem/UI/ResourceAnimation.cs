using System;
using Crescive.UI;
using DG.Tweening;
using UnityEngine;

namespace Crescive.ResourceSystem.UI
{
	[CreateAssetMenu(fileName = "Resource Animation", menuName = "Crescive/Resource System/Animations/Resource Animation")]
	public class ResourceAnimation : ScriptableObject
	{
		[SerializeField]
		private CanvasChannel canvasChannel;

		[SerializeField]
		private GameObject resourcePrefab;

		[SerializeField]
		private int maxCoinAmount;

		[SerializeField]
		private float spawnInterval;

		[SerializeField]
		private Vector2 randomFirstInterval;

		[SerializeField]
		private float punchScale;

		[SerializeField]
		private float punchDuration;

		[SerializeField]
		private Vector2 minMaxMoveDuration;

		[SerializeField]
		private Ease moveEase;

		[SerializeField]
		private bool randomDirectionBeforeDestination;

		[SerializeField]
		private Ease randomDirectionEase;

		[SerializeField]
		private float minPointDistance;

		[SerializeField]
		private float maxPointDistance;

		private Canvas Canvas => null;

		private void AnimateIncreaseCoin(Vector3 startPos, Vector3 endPos, Transform resourceImage, Action onComplete)
		{
		}

		private void AnimateDecreaseCoin(Vector3 startPos, Vector3 endPos, Transform resourceImage, Action onComplete)
		{
		}

		private void AnimateCoin(Vector3 startPos, Vector3 endPos, Transform resourceImage, Action onComplete)
		{
		}

		private void TryApplyFirstInterval(Sequence seq)
		{
		}

		public void AnimateResourceImage(Transform resourceImage)
		{
		}

		public void AnimateIncreaseCoin(float amount, Vector3 pos, Vector3 endPos, Transform resourceImage, Action onComplete)
		{
		}

		public void AnimateDecreaseCoin(float amount, Vector3 pos, Vector3 endPos, Transform resourceImage, Action onComplete)
		{
		}
	}
}
