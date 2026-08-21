using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class PinSlotColorEventListener : MonoBehaviour
	{
		[SerializeField]
		private VoidEvent OnResetToDefaultColor;

		[SerializeField]
		private PersistentColor lastSelectedColorPersistent;

		[SerializeField]
		private PinSlotsColorSetter pinSlotsColorSetter;

		[SerializeField]
		private Color initialColor;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ChangePinSlotColor(Color newColor)
		{
		}

		private void ResetToDefaultColor()
		{
		}

		private void InitializeColor()
		{
		}

		public void SetInitialColorAndInitializeColor()
		{
		}
	}
}
