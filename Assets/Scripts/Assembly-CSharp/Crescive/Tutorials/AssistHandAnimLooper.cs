using DG.Tweening;
using UnityEngine;

namespace Crescive.Tutorials
{
	public class AssistHandAnimLooper : MonoBehaviour
	{
		[SerializeField]
		private AssistHandController handController;

		[SerializeField]
		private Transform source;

		[SerializeField]
		private Transform target;

		[SerializeField]
		private bool startOnStart;

		[SerializeField]
		private bool snapBeforeStart;

		private Sequence moveSeq;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		public void StartMoving()
		{
		}

		public void StopMoving()
		{
		}

		public void SetSource(Transform source)
		{
		}

		public void SetTarget(Transform target)
		{
		}

		public void SetSourceAndTarget(Transform source, Transform target)
		{
		}

		private void SnapToSource()
		{
		}
	}
}
