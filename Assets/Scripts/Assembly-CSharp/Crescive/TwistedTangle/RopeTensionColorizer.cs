using UnityEngine;

namespace Crescive.TwistedTangle
{
	[DefaultExecutionOrder(999)]
	public class RopeTensionColorizer : MonoBehaviour
	{
		[SerializeField]
		private RopeTension tension;

		[SerializeField]
		private RopeColorizer colorizer;

		[SerializeField]
		private Renderer renderer;

		[SerializeField]
		private Color tensionBodyColor;

		[SerializeField]
		private bool updateOutlineColor;

		[SerializeField]
		private Color normalOutlineColor;

		[SerializeField]
		private Color tensionOutlineColor;

		[SerializeField]
		[Range(0f, 1f)]
		private float minTensionPercentage;

		private void Update()
		{
		}

		private void UpdateBodyColor()
		{
		}

		private void UpdateOutlineColor()
		{
		}

		public void SetUpdateOutlineColor(bool value)
		{
		}
	}
}
