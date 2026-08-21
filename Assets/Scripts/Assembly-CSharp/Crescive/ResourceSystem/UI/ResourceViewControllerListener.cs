using UnityEngine;
using UnityEngine.Events;

namespace Crescive.ResourceSystem.UI
{
	public class ResourceViewControllerListener : MonoBehaviour
	{
		[SerializeField]
		private ResourceViewController resourceViewController;

		[SerializeField]
		private bool triggerEventsOnEnable;

		[SerializeField]
		private bool triggerEventsOnStart;

		[SerializeField]
		private UnityEvent OnIncreaseCompleted;

		[SerializeField]
		private UnityEvent OnDecreaseCompleted;

		[SerializeField]
		private UnityEvent<bool> OnIsInfinite;

		[SerializeField]
		private UnityEvent<bool> OnIsNotInfinite;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void TriggerEvents()
		{
		}
	}
}
