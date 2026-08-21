using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class SetAllRopeColors : MonoBehaviour
	{
		[SerializeField]
		private bool shouldUseDarkerColors;

		[SerializeField]
		private float darkenAmount;

		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private ColorVariable activeColor;

		[SerializeField]
		private UnityEvent OnColorSetActivated;

		[SerializeField]
		private UnityEvent OnColorSetDeactivated;

		private bool isActive;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetColorOnChange()
		{
		}

		public void SetColors()
		{
		}

		public void SetDarkenAmount(float newDarkenAmount)
		{
		}

		public void FlipFlopActivation()
		{
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}
	}
}
