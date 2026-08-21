using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Utils
{
	public class BoundsInsideListener : MonoBehaviour
	{
		[SerializeField]
		private BoxCollider boundsCollider;

		[SerializeField]
		private Transform target;

		[SerializeField]
		private bool debugLog;

		public UnityEvent OnEnter;

		public UnityEvent OnExit;

		private bool isInside;

		private void Update()
		{
		}

		private void CheckInside()
		{
		}
	}
}
