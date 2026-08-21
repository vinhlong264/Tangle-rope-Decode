using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class ColorVariablePersistentSyncer : MonoBehaviour
	{
		[SerializeField]
		private ColorVariable colorVariableToRaise;

		[SerializeField]
		private PersistentColor colorPersistentSave;

		[SerializeField]
		private BoolEvent OnDeleteColorSelected;

		private bool isInDeleteMode;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ToggleDeleteMode(bool isTrue)
		{
		}

		public void Sync()
		{
		}
	}
}
