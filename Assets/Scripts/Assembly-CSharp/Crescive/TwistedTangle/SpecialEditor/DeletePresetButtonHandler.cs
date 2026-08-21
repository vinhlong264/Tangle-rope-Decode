using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class DeletePresetButtonHandler : MonoBehaviour
	{
		[SerializeField]
		private BoolEvent OnDeleteColorSelected;

		[SerializeField]
		private Toggle toggle;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void DeleteModeChange(bool newDeleteMode)
		{
		}

		public void ToggleDeleteMode(bool value)
		{
		}
	}
}
