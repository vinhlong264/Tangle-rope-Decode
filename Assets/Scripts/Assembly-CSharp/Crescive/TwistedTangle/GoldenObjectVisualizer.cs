using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class GoldenObjectVisualizer : MonoBehaviour
	{
		[SerializeField]
		public bool getModelOnParentObject;

		[SerializeField]
		public Transform modelParent;

		[SerializeField]
		public Material goldMaterial;

		public UnityEvent OnActive;

		public UnityEvent OnDeactive;

		public UnityEvent<bool> OnActiveChanged;

		public UnityEvent<bool> OnDeactiveChanged;

		[field: SerializeField]
		public bool Active { get; private set; }

		[field: SerializeField]
		public bool CanBeActive { get; private set; }

		public void SetActive(bool value)
		{
		}

		public void SetCanBeActive(bool value)
		{
		}

		public void Toggle()
		{
		}

		public void ReapplyIfActive()
		{
		}

		private void OnUpdated()
		{
		}

		private void TriggerEvents()
		{
		}

		private void UpdateVisuals()
		{
		}
	}
}
