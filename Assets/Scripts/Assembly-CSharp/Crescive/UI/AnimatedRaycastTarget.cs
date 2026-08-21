using UnityEngine;
using UnityEngine.EventSystems;

namespace Crescive.UI
{
	public class AnimatedRaycastTarget : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
	{
		public enum AnimationSettingsType
		{
			Local = 0,
			Global = 1
		}

		[SerializeField]
		private RectTransform animationTarget;

		[SerializeField]
		private AnimationSettingsType animationSettingsType;

		[SerializeField]
		private AnimatedRaycastTargetSettingsData settingsData;

		[SerializeField]
		private FloatAnimationSettings downSettings;

		[SerializeField]
		private FloatAnimationSettings enterSettings;

		[SerializeField]
		private FloatAnimationSettings exitSettings;

		[SerializeField]
		private FloatAnimationSettings clickPunchSettings;

		private bool down;

		private bool clicked;

		private FloatAnimationSettings DownSettings => null;

		private FloatAnimationSettings EnterSettings => null;

		private FloatAnimationSettings ExitSettings => null;

		private FloatAnimationSettings ClickPunchSettings => null;

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void PlayClickAnimation()
		{
		}
	}
}
