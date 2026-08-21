using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class SingleRopeColorizer : MonoBehaviour
	{
		[SerializeField]
		private ColorVariable selectedRopeColor;

		[SerializeField]
		private UnityEvent OnActivated;

		[SerializeField]
		private UnityEvent OnDeactivated;

		[SerializeField]
		private RopeChannel selectedRope;

		private bool isActive;

		public void FlipRopeClickActivation()
		{
		}

		public void FlipRopeClickActivation(bool isActive)
		{
		}

		public void SetClickedRopeColor(RopeEntity rope)
		{
		}

		public void ActivateColorizer()
		{
		}

		public void DeactivateColorizer()
		{
		}
	}
}
