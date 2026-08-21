using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Utils
{
	public class SelectorsToggleController : MonoBehaviour
	{
		[SerializeField]
		private ObjectSelectorsChannel selectorsChannel;

		public UnityEvent<bool> OnSelectionToggled;

		public UnityEvent OnSelectionEnabled;

		public UnityEvent OnSelectionDisabled;

		public UnityEvent<ObjectSelector> OnSelectorSelected;

		[field: SerializeField]
		public bool IsSelecting { get; private set; }

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void Setup()
		{
		}

		private void SubscribeToSelections()
		{
		}

		private void UnsubscribeFromSelections()
		{
		}

		private void OnAnySelectorSelected(ObjectSelector selector)
		{
		}

		private void UpdateSelectionVisuals()
		{
		}

		private void RaiseSelectionEvents()
		{
		}

		private void HandleEventsSubcription()
		{
		}

		public void ToggleSelection()
		{
		}
	}
}
