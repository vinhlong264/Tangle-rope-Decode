using Crescive.Localization;
using Crescive.Theming;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	[CreateAssetMenu(fileName = "Dynamic Quest UI Data", menuName = "Crescive/Monetization Features/Dynamic Quest/UI/Data/Dynamic Quest UI Data")]
	public class DynamicQuestUIData : ScriptableObject
	{
		[SerializeField]
		private UITheme uiTheme;

		[SerializeField]
		private StringLocalizationKey title;

		[SerializeField]
		private StringLocalizationKey description;

		[SerializeField]
		private StringLocalizationKey tokenName;

		[SerializeField]
		private StringLocalizationKey tokenNamePlural;

		[SerializeField]
		private Sprite mainFeatureSprite;

		[SerializeField]
		private Sprite warningFeatureSprite;

		[SerializeField]
		private Sprite titleFeatureSprite;

		[SerializeField]
		private Sprite tokenIcon;

		[SerializeField]
		private Sprite tokenFxIcon;

		public UITheme UITheme => null;

		public string Title => null;

		public string Description => null;

		public string TokenName => null;

		public string TokenNamePlural => null;

		public Sprite MainFeatureSprite => null;

		public Sprite WarningFeatureSprite => null;

		public Sprite TitleFeatureSprite => null;

		public Sprite TokenIcon => null;

		public Sprite TokenFxIcon => null;
	}
}
