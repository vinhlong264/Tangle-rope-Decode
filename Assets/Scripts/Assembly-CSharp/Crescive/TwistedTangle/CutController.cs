using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class CutController : MonoBehaviour
	{
		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private RopeRaycasterChannel ropeRaycasterChannel;

		public UnityEvent OnEnableCutting;

		public UnityEvent OnDisableCutting;

		public UnityEvent OnClickedRope;

		public UnityEvent OnAnyRopeCut;

		private bool isActivated;

		private RopeRaycastData currentRopeRaycastData;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnClickedRopeWithDataCallback(RopeRaycastData data)
		{
		}

		private void OnAnyRopeCutCallback()
		{
		}

		public void EnableCutting()
		{
		}

		public void DisableCutting()
		{
		}

		public void CutCurrentRope()
		{
		}
	}
}
