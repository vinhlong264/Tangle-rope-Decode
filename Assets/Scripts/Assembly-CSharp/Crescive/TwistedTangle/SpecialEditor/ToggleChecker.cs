using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class ToggleChecker : MonoBehaviour
	{
		[SerializeField]
		private UnityEvent OnToggleActivated;

		[SerializeField]
		private UnityEvent OnToggleDeactivated;

		private void ActivateToggle()
		{
		}

		private void DeactivateToggle()
		{
		}

		public void SwitchActivation(bool isActive)
		{
		}
	}
}
