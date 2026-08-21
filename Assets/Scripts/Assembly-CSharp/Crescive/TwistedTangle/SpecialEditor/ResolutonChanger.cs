using PersistentSO;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class ResolutonChanger : MonoBehaviour
	{
		private float resolutionScale;

		[SerializeField]
		private PersistentFloatVariable initialWidthPersistent;

		[SerializeField]
		private PersistentFloatVariable initialHeightPersistent;

		private float initialWidth;

		private float initialHeight;

		private void Awake()
		{
		}

		private void InitializeWidthHeight()
		{
		}

		public void UpdateResolution()
		{
		}

		public void SetResolutionScale(float scale)
		{
		}
	}
}
