using System;
using TMPro;
using UnityEngine;

namespace Crescive.ResourceSystem
{
	public class DateTimeCountdownTMPSetter : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text tmp;

		[SerializeField]
		private DateTimeCountdownTMPSetterMode mode;

		public void OnTimerUpdated(float timeLeft)
		{
		}

		private static string GetTextDHMS(TimeSpan timeSpan)
		{
			return null;
		}

		private static string GetTextColon(TimeSpan timeSpan)
		{
			return null;
		}

		private static string GetFirstPart(TimeSpan timeSpan)
		{
			return null;
		}

		private static string GetSecondPart(TimeSpan timeSpan)
		{
			return null;
		}
	}
}
