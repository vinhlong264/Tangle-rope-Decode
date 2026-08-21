using Crescive.GameStates;
using Crescive.HelperTypes;
using Crescive.TwistedTangle;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Game.Systems.StageLevels
{
	public class StageLevelsEventIntegrations : MonoBehaviour
	{
		[SerializeField]
		private StringVariableReference levelType;

		[SerializeField]
		private IntVariableReference failCount;

		[SerializeField]
		private IntSettableVariableReference timeLimit;

		[SerializeField]
		private IntSettableVariableReference performedTime;

		[SerializeField]
		private GameStateEvents gameStateEvents;

		public VoidEvent TimeUpAtomEvent;

		[SerializeField]
		private VoidEvent stageStartedEvent;

		[SerializeField]
		private LastLoadedLevelTrackData lastLoadedLevelTrackData;

		[SerializeField]
		private AnalyticsEventParamHelper analyticsEventParamHelper;

		[SerializeField]
		private CresciveEventSender eventSender;

		private float stageStartTime;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnStageCreated(LevelEvents.OnStageCreated obj)
		{
		}

		private void OnStageStarted(Void _)
		{
		}

		private void OnStageLevelMapStageCleared()
		{
		}

		private void OnTimeLimitZero()
		{
		}

		private void SendStageStarted(int objLevelId)
		{
		}

		private void SendStageFailed()
		{
		}

		private void SendStageCompleted()
		{
		}
	}
}
