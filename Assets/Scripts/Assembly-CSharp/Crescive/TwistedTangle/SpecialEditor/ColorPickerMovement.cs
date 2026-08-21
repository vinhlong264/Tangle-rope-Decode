using DG.Tweening;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class ColorPickerMovement : MonoBehaviour
	{
		[SerializeField]
		private Transform wheelTransform;

		[SerializeField]
		private Transform hexcodeTransform;

		[SerializeField]
		private Transform alphaSliderTransform;

		[SerializeField]
		private float movementDuration;

		[SerializeField]
		private float xRightOutOffset;

		[SerializeField]
		private float xLeftOutOffset;

		private Tweener wheelTweener;

		private Tweener hexcodeTweener;

		private Tweener alphaSliderTweener;

		private Vector3 wheelInitialPosition;

		private Vector3 hexcodeInitialPosition;

		private Vector3 alphaSliderInitialPosition;

		private bool isActive;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void InitializePositions()
		{
		}

		private void SetInitialPositions()
		{
		}

		private void MoveIn()
		{
		}

		private void MoveOut()
		{
		}

		private void KillTweens()
		{
		}

		private void ActivatePicker()
		{
		}

		private void DeactivatePicker()
		{
		}

		public void FlipFlopActivation()
		{
		}
	}
}
