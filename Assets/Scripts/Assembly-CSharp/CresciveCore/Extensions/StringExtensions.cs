using System.Text.RegularExpressions;

namespace CresciveCore.Extensions
{
	public static class StringExtensions
	{
		private static readonly Regex SWhitespace;

		public static string RemoveWhitespace(this string value)
		{
			return null;
		}

		public static bool IsNullOrEmpty(this string value)
		{
			return false;
		}

		public static bool IsNullOrWhiteSpace(this string value)
		{
			return false;
		}
	}
}
