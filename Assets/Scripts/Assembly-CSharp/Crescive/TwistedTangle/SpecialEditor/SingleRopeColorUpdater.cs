using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class SingleRopeColorUpdater : MonoBehaviour
	{
		[SerializeField]
		private ColorVariable selectedRopeColor;

		[SerializeField]
		private RopeChannel selectedRope;

		[SerializeField]
		private UnityEvent OnRopeSelectionActivated;

		[SerializeField]
		private UnityEvent OnRopeSelectionDeactivated;

		private bool isActive;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetSelectedRopeColor(Color newColor)
		{
		}

		private void ActivateRopeSelection()
		{
		}

		private void DeactivateRopeSelection()
		{
		}

		public void SetRopeColor()
		{
		}

		public void SwitchActivation(bool isActive)
		{
		}
	}
}
