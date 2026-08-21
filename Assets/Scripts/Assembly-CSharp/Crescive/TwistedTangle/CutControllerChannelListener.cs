using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class CutControllerChannelListener : MonoBehaviour
	{
		[SerializeField]
		private CutControllerChannel controllerChannel;

		public UnityEvent OnEnableCutting;

		public UnityEvent OnDisableCutting;

		public UnityEvent OnAnyRopeCut;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
