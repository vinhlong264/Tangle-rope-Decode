using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public abstract class BaseRopeSelectToggler : MonoBehaviour
	{
		[SerializeField]
		private RopeRaycasterChannel ropeRaycasterChannel;

		[SerializeField]
		private bool autoDeactivate;

		[SerializeField]
		private bool autoDeactivateOnDisable;

		private bool active;

		public UnityEvent OnActivated;

		public UnityEvent OnDeactivated;

		public UnityEvent<bool> OnActivationChanged;

		public UnityEvent<RopeEntity> OnRopeSelected;

		protected abstract void OnHitRope(RopeRaycastData ropeRaycastData);

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnHitRopeCallback(RopeRaycastData ropeRaycastData)
		{
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}

		public void Toggle()
		{
		}

		private void UpdateComponentEnable()
		{
		}
	}
}
