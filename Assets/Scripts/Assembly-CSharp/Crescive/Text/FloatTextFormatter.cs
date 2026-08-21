using System.Globalization;
using UnityEngine;

namespace Crescive.Text
{
	[CreateAssetMenu(fileName = "Float Text Formatter", menuName = "Crescive/Text Formatter/Float Text Formatter")]
	public class FloatTextFormatter : BaseTextFormatter
	{
		[SerializeField]
		private bool rounded;

		[SerializeField]
		private string format;

		[SerializeField]
		private bool isPriceText;

		[SerializeField]
		private NumberAbbreviationSettings abbreviation;

		protected override string FormatTextInternal(string text)
		{
			return null;
		}

		private static bool IsZero(float v)
		{
			return false;
		}

		private static string GetFreeText(CultureInfo culture)
		{
			return null;
		}
	}
}
