using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class MeshColorEventListener : MonoBehaviour
	{
		[SerializeField]
		private VoidEvent OnResetToDefaultColor;

		[SerializeField]
		private MeshRenderer objectRenderer;

		[SerializeField]
		private PersistentColor lastSelectedColorPersistent;

		[SerializeField]
		private Color initialColor;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ChangeMeshColor(Color newColor)
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
