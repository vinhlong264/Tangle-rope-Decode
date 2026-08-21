using System;

namespace CresciveCore.Extensions
{
	public static class StringDateTimeExtensions
	{
		public static DateTime GetDateTimeValueFormatted(this string value)
		{
			return default(DateTime);
		}

		public static string GetStringValueFormatted(this DateTime dateTime)
		{
			return null;
		}

		public static DateTime? GetDateTimeValueFormattedNullable(this string value)
		{
			return null;
		}
	}
}
