using UnityEngine;

namespace CresciveCore.Utils
{
	public class UIGradientSetter : MonoBehaviour
	{
		[SerializeField]
		private UIGradientControllerEvents gradientControllerEvents;

		[SerializeField]
		private UIGradientColors colors;

		[SerializeField]
		private bool setOnEnable;

		[SerializeField]
		private bool restoreOnDisable;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetColors()
		{
		}

		public void RestoreOriginalColors()
		{
		}
	}
}
