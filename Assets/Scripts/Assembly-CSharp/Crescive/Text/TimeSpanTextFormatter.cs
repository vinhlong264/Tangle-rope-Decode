using System;
using UnityEngine;

namespace Crescive.Text
{
	[CreateAssetMenu(fileName = "Time Span Text Formatter", menuName = "Crescive/Text Formatter/Time Span Text Formatter")]
	public class TimeSpanTextFormatter : BaseTextFormatter
	{
		private enum TimeTextFormatParseType
		{
			FromSeconds = 0,
			FromMinutes = 1,
			FromHours = 2,
			FromDays = 3
		}

		private enum TimeTextFormatType
		{
			DaysHoursMinutesSeconds = 0,
			DaysHoursMinutes = 1,
			DaysHours = 2,
			Days = 3,
			HoursMinutesSeconds = 4,
			HoursMinutes = 5,
			Hours = 6,
			MinutesSeconds = 7,
			Minutes = 8,
			Seconds = 9,
			Dynamic = 10000,
			DynamicShort = 10001,
			DynamicShortHMS = 10002,
			TwoParts = 20000
		}

		private enum TimeTextDisplayType
		{
			WithColons = 0,
			WithLettersShort = 1,
			WithLettersMid = 2,
			WithLettersLong = 3
		}

		[SerializeField]
		private TimeTextFormatParseType parseType;

		[SerializeField]
		private TimeTextFormatType formatType;

		[SerializeField]
		private TimeTextDisplayType displayType;

		private string DaysShort => null;

		private string DaysMid => null;

		private string DaysLong => null;

		private string HoursShort => null;

		private string HoursMid => null;

		private string HoursLong => null;

		private string MinutesShort => null;

		private string MinutesMid => null;

		private string MinutesLong => null;

		private string SecondsShort => null;

		private string SecondsMid => null;

		private string SecondsLong => null;

		private string Separator => null;

		protected override string FormatTextInternal(string text)
		{
			return null;
		}

		private string GetTextDHMS(TimeSpan timeSpan)
		{
			return null;
		}

		private string GetTextDHM(TimeSpan timeSpan)
		{
			return null;
		}

		private string GetTextDH(TimeSpan timeSpan)
		{
			return null;
		}

		private string GetTextD(TimeSpan timeSpan)
		{
			return null;
		}

		private string GetTextHMS(TimeSpan timeSpan)
		{
			return null;
		}

		private string GetTextHM(TimeSpan timeSpan)
		{
			return null;
		}

		private string GetTextH(TimeSpan timeSpan)
		{
			return null;
		}

		private string GetTextTotalH(TimeSpan timeSpan, bool floor)
		{
			return null;
		}

		private string GetTextMS(TimeSpan timeSpan)
		{
			return null;
		}

		private string GetTextM(TimeSpan timeSpan)
		{
			return null;
		}

		private string GetTextS(TimeSpan timeSpan)
		{
			return null;
		}

		private string GetTextDynamic(TimeSpan timeSpan)
		{
			return null;
		}

		private string GetTextDynamicShort(TimeSpan timeSpan)
		{
			return null;
		}

		private string GetTextDynamicShortHMS(TimeSpan timeSpan)
		{
			return null;
		}

		private string GetTextTwoParts(TimeSpan timeSpan)
		{
			return null;
		}
	}
}
