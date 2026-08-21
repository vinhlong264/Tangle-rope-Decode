using Crescive.HelperTypes;
using Crescive.Levels;
using UnityEngine;

namespace Crescive.TwistedTangle.SingleLineProgression
{
	public class ExtraTimeElephantEventsIntegration : MonoBehaviour
	{
		[SerializeField]
		private InGameOfferDataService timeOutInGameOfferDataService;

		[SerializeField]
		private CresciveEventSender eventSender;

		[SerializeField]
		private StringVariableReference levelType;

		[SerializeField]
		private IntVariableReference failCount;

		[SerializeField]
		private LevelsSettingsService levelsSettingsService;

		[SerializeField]
		private LastLoadedLevelTrackData lastLoadedLevelTrackData;

		[SerializeField]
		private BoolVariableReference isSingleLineEnabled;

		[SerializeField]
		private AnalyticsEventParamHelper analyticsEventParamHelper;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnExtraTimeGranted(InGameOfferItemGrantedArgs args)
		{
		}
	}
}
