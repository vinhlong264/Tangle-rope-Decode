using Crescive.HelperTypes;
using Crescive.Levels;
using Crescive.ResourceSystem;
using Crescive.TwistedTangle;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace ElephantSDK
{
	public class ElephantLevelEventsIntegration : MonoBehaviour
	{
		[SerializeField]
		private LevelsSettingsService levelsSettingsService;

		[SerializeField]
		private IntVariableReference currentStageIndex;

		[SerializeField]
		private BoolVariableReference isStageLevel;

		[SerializeField]
		private IntVariableReference performedMoveCount;

		[SerializeField]
		private IntVariableReference performedTime;

		[SerializeField]
		private IntVariableReference failCount;

		[SerializeField]
		private LastLoadedLevelTrackData lastLoadedLevelTrackData;

		[SerializeField]
		private ResourceChannel coinResourceChannel;

		[SerializeField]
		private BoolVariableReference isSingleLineEnabled;

		[SerializeField]
		private StringVariable levelType;

		[SerializeField]
		private StringVariable failReasonVariable;

		[SerializeField]
		private IntSettableVariableReference timeLimit;

		public void OnLevelStarted(LevelEventArgs args)
		{
		}

		public void OnLevelCompleted(LevelEventArgs args)
		{
		}

		public void OnLevelFailed(LevelEventArgs args)
		{
		}

		public void OnLevelGiveUp(LevelEventArgs args)
		{
		}

		private Params GetLevelStartedEventParameters(int levelId)
		{
			return null;
		}

		private Params GetLevelCompletedEventParameters(int levelId)
		{
			return null;
		}

		private void CheckColorLevelFailInfo(int levelNumber, string LevelIdString)
		{
		}

		private Params GetLevelFailedEventParameters(int levelId, string failReason)
		{
			return null;
		}

		private Params GetLevelGiveUpEventParameters(int levelId, string failReason)
		{
			return null;
		}

		private string GetRemainingMoveOrTimeParamName(int levelId)
		{
			return null;
		}

		private double GetRemainingMoveOrTimeCount(int levelId)
		{
			return 0.0;
		}

		private int GetRemainingMoveCount(int levelId)
		{
			return 0;
		}

		private int GetRemainingTimeCount(int levelId)
		{
			return 0;
		}

		private int GetRemainingTimeCount()
		{
			return 0;
		}
	}
}
