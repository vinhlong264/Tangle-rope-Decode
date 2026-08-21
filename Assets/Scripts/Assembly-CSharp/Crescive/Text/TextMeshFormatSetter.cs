using TMPro;
using UnityEngine;

namespace Crescive.Text
{
	public class TextMeshFormatSetter : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text textMesh;

		[SerializeField]
		private string prefix;

		[SerializeField]
		private string postFix;

		[SerializeField]
		private string afterPrefix;

		[SerializeField]
		private string beforePostfix;

		[SerializeField]
		private string numberFormat;

		public TMP_Text TextMesh => null;

		private void ConstructText(string text)
		{
		}

		public void SetText(string text)
		{
		}

		public void SetTextNumber(int value)
		{
		}

		public void SetTextNumber(float value)
		{
		}

		public void SetTextNumberNoDecimals(float value)
		{
		}

		public void SetTextNumberAbbreviated(int value)
		{
		}

		public void SetTextNumberAbbreviated(float value)
		{
		}

		public void SetTextNumberFormatted(int value, string format)
		{
		}

		public void SetTextNumberFormatted(float value, string format)
		{
		}

		public void SetPrefix(string prefix)
		{
		}

		public void SetPostfix(string postfix)
		{
		}
	}
}
