using Crescive.HelperTypes;
using Crescive.Levels;
using UnityEngine;

namespace Crescive.TwistedTangle.SingleLineProgression
{
	public class InGameOfferEventsSender : MonoBehaviour
	{
		[SerializeField]
		private LevelsSettingsService levelsSettingsService;

		[SerializeField]
		private CresciveEventSender eventSender;

		[SerializeField]
		private IntVariableReference failCount;

		[SerializeField]
		private LastLoadedLevelTrackData lastLoadedLevelTrackData;

		[SerializeField]
		private StringVariableReference levelType;

		[SerializeField]
		private BoolVariableReference isSingleLineEnabled;

		[SerializeField]
		private AnalyticsEventParamHelper analyticsEventParamHelper;

		public void OnItemGranted(InGameOfferItemGrantedArgs args)
		{
		}
	}
}
