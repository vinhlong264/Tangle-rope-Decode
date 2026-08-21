using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor.UI
{
	public class HexColorField : MonoBehaviour
	{
		[SerializeField]
		private TMP_InputField inputField;

		[SerializeField]
		private ColorVariable activeColor;

		[SerializeField]
		private ColorVariable selectedColor;

		public string ValueInField { get; private set; }

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetHexCode(Color colorToChange)
		{
		}

		private void ChangeValue(string valueToPass)
		{
		}

		public void SetColorFromHex()
		{
		}
	}
}
