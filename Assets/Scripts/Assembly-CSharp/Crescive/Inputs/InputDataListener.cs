using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Inputs
{
	public class InputDataListener : MonoBehaviour
	{
		[SerializeField]
		private PlayerInputData inputData;

		public UnityEvent OnTapped;

		public UnityEvent OnTappedRaw;

		public UnityEvent OnReleased;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected virtual void OnTappedCallback()
		{
		}

		protected virtual void OnTappedRawCallback()
		{
		}

		protected virtual void OnReleasedCallback()
		{
		}
	}
}
