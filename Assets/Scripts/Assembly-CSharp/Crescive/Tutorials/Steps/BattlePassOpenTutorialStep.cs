using Crescive.LiveEvents.BattlePass;
using Crescive.Navigation;
using Crescive.Sequencer;
using CresciveCore;
using UnityEngine;

namespace Crescive.Tutorials.Steps
{
	public class BattlePassOpenTutorialStep : TutorialStepManager
	{
		[SerializeField]
		private BattlePassSystem battlePassSystem;

		[SerializeField]
		private NavigationChannel menuPopUpNavigationChannel;

		[SerializeField]
		private SequencerChannel returnedHomeSequencerChannel;

		[SerializeField]
		private LoaderChannel loaderChannel;

		public override ITutorialState? CheckState()
		{
			return null;
		}

		public override bool ShouldActivate(ITutorialState? currentState)
		{
			return false;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnBattlePassSaveDataChanged(BattlePassData _)
		{
		}

		private void ValidateState()
		{
		}

		private void RefreshFirstClaimTutorialCompleted()
		{
		}

		private void RefreshFirstRewardNeedsToBeClaimable()
		{
		}

		public override void OnEnter(ITutorialState? currentState)
		{
		}

		public override void WhileActive(ITutorialState? currentState)
		{
		}

		public override void OnExit(ITutorialState? currentState)
		{
		}
	}
}
