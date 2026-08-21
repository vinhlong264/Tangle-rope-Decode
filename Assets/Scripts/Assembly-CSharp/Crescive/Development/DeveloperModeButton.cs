using System.Collections.Generic;
using PersistentSO;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Crescive.Development
{
	public class DeveloperModeButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
	{
		private class ClickHandlerObject
		{
			public IPointerClickHandler ClickHandler;

			public IPointerEnterHandler PointerEnterHandler;

			public IPointerExitHandler PointerExitHandler;

			public IPointerDownHandler PointerDownHandler;

			public IPointerUpHandler PointerUpHandler;

			public GameObject GameObject;

			public ClickHandlerObject(IPointerClickHandler clickHandler, GameObject gameObject)
			{
			}
		}

		[SerializeField]
		private PersistentBoolVariable developerMode;

		[SerializeField]
		private int clickCountToToggle;

		[SerializeField]
		private float clickCountResetTime;

		[SerializeField]
		private Button devModeButton;

		private int clickCount;

		private float timer;

		private PointerEventData PointerEventData => null;

		private void Update()
		{
		}

		private void HandleClickCountOnClick()
		{
		}

		private void RaycastOtherUIEelementsOnClick()
		{
		}

		private void RaycastOtherUIElementsOnPointerEnter()
		{
		}

		private void RaycastOtherUIElementsOnPointerExit()
		{
		}

		private void RaycastOtherUIElementsOnPointerDown()
		{
		}

		private void RaycastOtherUIElementsOnPointerUp()
		{
		}

		private List<ClickHandlerObject> GetRaycastedOtherUIElements(PointerEventData pointerEventData)
		{
			return null;
		}

		public void OnClicked()
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
	}
}
