using System;
using DG.Tweening;
using UnityEngine;

namespace Plinko
{
	public class SpawnPoint : MonoBehaviour
	{
		[SerializeField]
		private SpriteRenderer buttonVisual;

		[SerializeField]
		private Color buttonAnimationColor;

		[SerializeField]
		private SpriteRenderer arrowVisual;

		[SerializeField]
		private Color arrowAnimationColor;

		[SerializeField]
		private float animationDuration;

		[SerializeField]
		private float waitDuration;

		[SerializeField]
		private SpriteMask plinkoGameSpriteMask;

		[SerializeField]
		private GameObject notEnoughBallsTooltip;

		public int TriggerAreaID;

		public Transform Point;

		private Action<SpawnPoint, bool> onSpawnPointTriggered;

		private Sequence animationSequence;

		private BallCountArea ballCountArea;

		private static Sequence notEnoughBallSequence;

		private Vector3 defaultScale;

		internal void Initialize(Action<SpawnPoint, bool> onSpawnPointTriggered, BallCountArea ballCountArea)
		{
		}

		private void OnMouseDown()
		{
		}

		private void PlayButtonClickAnimation(Action onPressedMoment)
		{
		}
	}
}
