using Crescive.GameStates;
using Crescive.Navigation;
using Crescive.Offer;
using Crescive.Scheduler;
using Crescive.Sequencer;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Serialization;

namespace Crescive.LiveEvents.BattlePass
{
	public class BattlePassManager : MonoBehaviour
	{
		public static BattlePassManager instance;

		[Header("References")]
		[SerializeField]
		private GameStateEvents gameStateEvents;

		[SerializeField]
		private BattlePassDataService battlePassDataService;

		[SerializeField]
		private PersistentBattlePassData persistentBattlePassData;

		[SerializeField]
		private BattlePassSystem battlePassSystem;

		[FormerlySerializedAs("navigationChannel")]
		[SerializeField]
		private NavigationChannel menuPopUpNavigationChannel;

		[SerializeField]
		private StringReference battlePassPanelId;

		[SerializeField]
		private StringReference battlePassStartPanelId;

		[SerializeField]
		private StringReference battlePassFinishPanelId;

		[SerializeField]
		private StringReference battlePassGoldenTicketClaimRewardsPanel;

		[SerializeField]
		private SchedulerSystem schedulerSystem;

		[SerializeField]
		private VoidBaseEventReference loadedSceneReadyEvent;

		[SerializeField]
		private StringCompareCondition isSceneTypeHome;

		[SerializeField]
		private SequencerChannel returnedHomeSequencerChannel;

		[SerializeField]
		private SequenceStep activateSchedulesStep;

		[SerializeField]
		private SequenceStep battlePassStartSequenceStep;

		[SerializeField]
		private SequenceStep battlePassFinishSequenceStep;

		[SerializeField]
		private SequenceStep battlePassGoldenTicketClaimStep;

		[SerializeField]
		private OfferControllerChannel offerControllerChannel;

		private const string BattlePassDefaultScheduleId = "battle_pass_default";

		public void AddToken(int amount)
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnBattlePassStartStepStarted(SequenceStep _)
		{
		}

		private void OnBattlePassGoldenTicketClaimStepStarted(SequenceStep _)
		{
		}

		private void OnBattlePassFinishStepStarted(SequenceStep step)
		{
		}

		private void OnScheduleActivatedNow(ScheduleActivatedNowArgs args)
		{
		}

		private void OnLevelPlay()
		{
		}

		private void OnLevelCompleted()
		{
		}

		private void HandleBattlePassGoingLive()
		{
		}

		private void Update()
		{
		}

		private void OnReturnedHome()
		{
		}

		private void HandleFinishedPass()
		{
		}
	}
}
