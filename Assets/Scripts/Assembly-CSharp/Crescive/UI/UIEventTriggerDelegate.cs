using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Crescive.UI
{
	public class UIEventTriggerDelegate : MonoBehaviour, IPointerMoveHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, ISelectHandler, IDeselectHandler, IScrollHandler, IUpdateSelectedHandler, ISubmitHandler, ICancelHandler
	{
		[SerializeField]
		private GameObject target;

		private IPointerMoveHandler[] moveHandlers;

		private IPointerEnterHandler[] enterHandlers;

		private IPointerExitHandler[] exitHandlers;

		private IPointerDownHandler[] downHandlers;

		private IPointerUpHandler[] upHandlers;

		private IPointerClickHandler[] clickHandlers;

		private ISelectHandler[] selectHandlers;

		private IDeselectHandler[] deselectHandlers;

		private IScrollHandler[] scrollHandlers;

		private IUpdateSelectedHandler[] updateSelectedHandlers;

		private ISubmitHandler[] submitHandlers;

		private ICancelHandler[] cancelHandlers;

		public UnityEvent OnBeforeTargetClick;

		public UnityEvent OnAfterTargetClick;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetTarget(GameObject newTarget)
		{
		}

		public void OnPointerMove(PointerEventData eventData)
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void OnSelect(BaseEventData eventData)
		{
		}

		public void OnDeselect(BaseEventData eventData)
		{
		}

		public void OnScroll(PointerEventData eventData)
		{
		}

		public void OnUpdateSelected(BaseEventData eventData)
		{
		}

		public void OnSubmit(BaseEventData eventData)
		{
		}

		public void OnCancel(BaseEventData eventData)
		{
		}
	}
}
