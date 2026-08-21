using System;
using TMPro;
using UnityEngine.UI;

namespace StudioRollic.TimeSystem
{
	internal class RemainingTimeData
	{
		public string Id;

		public float TimeRemaining;

		public Text TimeText;

		public TextMeshProUGUI TimeTextMeshPro;

		public bool UseColon;

		public bool UseSpace;

		public bool ShowAsHours;

		public Action OnTimeEnded;
	}
}
