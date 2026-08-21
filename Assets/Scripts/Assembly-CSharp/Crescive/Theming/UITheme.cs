using UnityEngine;

namespace Crescive.Theming
{
	[CreateAssetMenu(fileName = "UI Theme", menuName = "Crescive/UI/Theme/UI Theme")]
	public class UITheme : ScriptableObject
	{
		[SerializeField]
		private UIThemeData data;

		public UIThemeColorData ColorData => null;

		public UIThemePopupData PopupData => null;

		public UIThemeCountdownData CountdownData => null;

		public UIThemeProgressBarData ProgressBarData => null;

		public UIThemeButtonData ButtonData => null;

		public UIThemeTabData TabData => null;
	}
}
