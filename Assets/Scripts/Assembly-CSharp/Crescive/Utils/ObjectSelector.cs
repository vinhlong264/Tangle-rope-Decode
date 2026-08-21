using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Utils
{
	public class ObjectSelector : MonoBehaviour
	{
		[SerializeField]
		private bool isSelecting;

		public UnityEvent OnSelectionEnabled;

		public UnityEvent OnSelectionDisabled;

		public UnityEvent<bool> OnSelectionEnableChanged;

		public UnityEvent<ObjectSelector> OnSelected;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void TriggerSelectionEvents()
		{
		}

		public void SetCanSelect(bool value)
		{
		}

		public void ToggleCanSelect()
		{
		}

		public void Select()
		{
		}
	}
}
