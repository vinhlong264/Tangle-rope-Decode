using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.UI
{
	public class AnimatedTimerAlertLight : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private CanvasGroup hiderCanvasGroup;

		[Space]
		[SerializeField]
		private IntReference currentTime;

		[SerializeField]
		private List<float> alertTimes;

		[SerializeField]
		private List<float> remainingAlertTimes;

		private bool isActive;

		private bool CanCheck => false;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void CheckRemainingAlertTimes()
		{
		}

		private void TriggerAlert(bool continuous)
		{
		}

		public void Initialize()
		{
		}

		public void SetActive(bool value)
		{
		}

		public void Show(bool immediate)
		{
		}

		public void Hide(bool immediate)
		{
		}
	}
}
