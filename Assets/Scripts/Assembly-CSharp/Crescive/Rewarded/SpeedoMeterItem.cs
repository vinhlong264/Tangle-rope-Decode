using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Rewarded
{
	public class SpeedoMeterItem : MonoBehaviour
	{
		[SerializeField]
		private float factor;

		[SerializeField]
		private TextMeshProUGUI text;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[Range(0f, 1f)]
		[SerializeField]
		private float unselectedAlpha;

		[SerializeField]
		private float activeScale;

		[SerializeField]
		private float animSpeed;

		public UnityEvent OnActive;

		public UnityEvent OnDeactive;

		public UnityEvent<bool> OnActiveStateChanged;

		private bool active;

		private Vector3 defaultScale;

		public float Factor => 0f;

		public bool Active => false;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void UpdateText()
		{
		}

		public void SetActiveState(bool activate)
		{
		}

		private void UpdateVisuals()
		{
		}

		private void UpdateAlpha()
		{
		}

		private void UpdateAnim()
		{
		}

		public void SetFactor(float newFactor)
		{
		}
	}
}
