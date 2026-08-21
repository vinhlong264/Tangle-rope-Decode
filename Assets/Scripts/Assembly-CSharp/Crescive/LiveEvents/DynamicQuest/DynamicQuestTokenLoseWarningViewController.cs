using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestTokenLoseWarningViewController : BaseDynamicQuestViewController
	{
		[SerializeField]
		private StringSettableVariableReference tokenNamePlural;

		[SerializeField]
		private FloatSettableVariableReference collectedTokens;

		[SerializeField]
		private Image tokenIcon;

		[SerializeField]
		private Image warningFeatureImage;

		protected override void SyncBindingsInternal()
		{
		}
	}
}
