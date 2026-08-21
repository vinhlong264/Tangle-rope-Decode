using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Crescive.UI
{
	[RequireComponent(typeof(NestedScrollRectController))]
	public class NestedScrollRect : ScrollRect
	{
		private bool routeToParent;

		private IInitializePotentialDragHandler[] parentInitializePotentialDragHandlers;

		private IBeginDragHandler[] parentBeginDragHandlers;

		private IDragHandler[] parentDragHandlers;

		private IEndDragHandler[] parentEndDragHandlers;

		public void InitializeParentHandlers(ScrollRect parentScrollRect)
		{
		}

		public override void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		public override void OnDrag(PointerEventData eventData)
		{
		}

		public override void OnEndDrag(PointerEventData eventData)
		{
		}
	}
}
