using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.TwistedTangle
{
	public class RopeColorFeaturePanel : MonoBehaviour
	{
		[SerializeField]
		private Toggle toggle;

		[SerializeField]
		private BoolVariable useNearColors;

		[SerializeField]
		private BoolVariable useCustomNearColors;

		[SerializeField]
		private ColorValueList customNearColors;

		[SerializeField]
		private GameObject colorParent;

		[SerializeField]
		private List<ColorSample> colorValues;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void UpdateList(Color color, int index)
		{
		}

		private void OnUseNearColorsChanged(bool switchOn)
		{
		}

		private void UpdateUI()
		{
		}

		private void OnColorListChanged()
		{
		}
	}
}
