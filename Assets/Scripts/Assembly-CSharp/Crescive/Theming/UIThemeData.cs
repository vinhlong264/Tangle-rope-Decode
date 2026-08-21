using System;
using UnityEngine;

namespace Crescive.Theming
{
	[Serializable]
	public class UIThemeData
	{
		[SerializeField]
		private UIThemeColorData colorData;

		[SerializeField]
		private UIThemePopupData popupData;

		[SerializeField]
		private UIThemeCountdownData countdownData;

		[SerializeField]
		private UIThemeProgressBarData progressBarData;

		[SerializeField]
		private UIThemeButtonData buttonData;

		[SerializeField]
		private UIThemeTabData tabData;

		public UIThemeColorData ColorData => null;

		public UIThemePopupData PopupData => null;

		public UIThemeCountdownData CountdownData => null;

		public UIThemeProgressBarData ProgressBarData => null;

		public UIThemeButtonData ButtonData => null;

		public UIThemeTabData TabData => null;
	}
}
