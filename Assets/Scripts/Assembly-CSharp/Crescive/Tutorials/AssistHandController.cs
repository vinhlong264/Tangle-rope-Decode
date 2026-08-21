using DG.Tweening;
using UnityEngine;

namespace Crescive.Tutorials
{
	public class AssistHandController : MonoBehaviour
	{
		[SerializeField]
		private Transform scalePivot;

		[SerializeField]
		private float moveSourceDuration;

		[SerializeField]
		private float moveTargetDuration;

		[SerializeField]
		private float downScale;

		[SerializeField]
		private float scaleDuration;

		[SerializeField]
		private float delay;

		public Sequence MoveFromSourceToTarget(Vector3 source, Vector3 target, int loops = 0)
		{
			return null;
		}

		public Sequence MoveFromSourceToTarget(Transform source, Transform target, int loops = 0)
		{
			return null;
		}

		public void MoveFromSourceToTargetInfinity(Transform source, Transform target)
		{
		}
	}
}
