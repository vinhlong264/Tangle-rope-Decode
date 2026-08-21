using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Crescive.UI
{
	public class ButtonHoldListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerExitHandler
	{
		[SerializeField]
		private float period;

		private bool pointerDown;

		private float pointerDownTimer;

		public UnityEvent OnDown;

		public UnityEvent OnHold;

		public UnityEvent OnUp;

		public UnityEvent OnExit;

		private void Update()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		private void UpdateHold()
		{
		}

		private void Reset()
		{
		}
	}
}
