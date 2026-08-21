using Crescive.HelperTypes;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.UI
{
	[DefaultExecutionOrder(1)]
	public class ProgressBar : MonoBehaviour
	{
		[SerializeField]
		private Slider slider;

		[SerializeField]
		private Ease progressEase;

		[SerializeField]
		private float fillDuration;

		[SerializeField]
		private FloatSettableVariableReference value;

		[SerializeField]
		private FloatSettableVariableReference maxValue;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void UpdateMaxValue(float newMaxValue)
		{
		}

		private void UpdateProgress(float newValue)
		{
		}
	}
}
