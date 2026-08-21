using System.Collections.Generic;
using Crescive.Draggables.EventParams;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Draggables
{
	[DefaultExecutionOrder(-10)]
	public class DropTarget : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private GameObject targetGameObject;

		[Header("Settings")]
		[SerializeField]
		private bool initialCanSelect;

		[Header("Settings")]
		[SerializeField]
		private List<BaseDragFilter> dropFilters;

		[Header("Events")]
		public UnityEvent<DraggableDropEventParams> OnDroppedHere;

		public UnityEvent<DraggableDropEventParams> OnDropTargetSelected;

		public UnityEvent<DraggableDropEventParams> OnDropTargetUnselected;

		public UnityEvent OnEnableIndicator;

		public UnityEvent OnDisableIndicator;

		public GameObject TargetGameObject => null;

		public bool CanSelect { get; private set; }

		private void Awake()
		{
		}

		public void SetTargetGameObject(Transform t)
		{
		}

		public void SetCanSelect(bool value)
		{
		}

		public void SetIndicator(bool active)
		{
		}

		public bool CanDrop(Draggable draggable)
		{
			return false;
		}
	}
}
