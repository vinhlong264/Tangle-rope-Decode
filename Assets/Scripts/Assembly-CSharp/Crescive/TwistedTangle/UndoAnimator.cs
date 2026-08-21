using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class UndoAnimator : MonoBehaviour
	{
		[SerializeField]
		private GameObject model;

		[SerializeField]
		private Transform moveTransform;

		[SerializeField]
		private Transform movePoint1;

		[SerializeField]
		private Transform movePoint2;

		[SerializeField]
		private Transform movePoint3;

		[SerializeField]
		private Transform rotateTransform;

		[SerializeField]
		private List<ParticleSystem> particleSystems;

		private Quaternion initialRotation;

		public UnityEvent OnUndo;

		private void Awake()
		{
		}

		private void InitializeAnimation()
		{
		}

		private void MoveRotateAnimation()
		{
		}

		private void StartParticles()
		{
		}

		private void StopParticles()
		{
		}

		private void ClearParticles()
		{
		}

		public void PlayAnimation()
		{
		}

		public void CancelAnimation()
		{
		}
	}
}
