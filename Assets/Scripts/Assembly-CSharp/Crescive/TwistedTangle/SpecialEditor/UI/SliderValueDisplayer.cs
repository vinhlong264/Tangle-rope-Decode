using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Crescive.TwistedTangle.SpecialEditor.UI
{
	public class SliderValueDisplayer : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI minText;

		[SerializeField]
		private TextMeshProUGUI maxText;

		[SerializeField]
		private Slider slider;

		[SerializeField]
		private TextMeshProUGUI currentValueText;

		[SerializeField]
		private UnityEvent<float> onValueChanged;

		[SerializeField]
		private float minValue;

		[SerializeField]
		private float maxValue;

		[SerializeField]
		private float currentValue;

		public Slider Slider => null;

		private void OnValidate()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSliderValueChanged(float sliderVal)
		{
		}

		private void UpdateUI()
		{
		}

		public void SetSliderValue(float newValue)
		{
		}

		public void ResetSliderValue()
		{
		}

		public void SetSliderValueWithoutNotify(float newValue)
		{
		}

		public float GetCurrentValue(float newVal)
		{
			return 0f;
		}

		public void SetSliderByRealValue(float realValue)
		{
		}

		public void SetMinValue(float newMinValue)
		{
		}

		public void SetMaxValue(float newMaxValue)
		{
		}
	}
}
