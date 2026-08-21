using Crescive.LiveEvents.BattlePass;
using Crescive.Navigation;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Tutorials.Steps
{
	public class BattlePassShowableTutorialsSteps : TutorialStepManager
	{
		[SerializeField]
		private BattlePassSystem battlePassSystem;

		[SerializeField]
		private NavigationChannel menuPopUpNavigationStack;

		[SerializeField]
		private StringReference battlePassPanelId;

		private TanglePassTutorialState? m_TutorialState;

		public void OnProgressClicked()
		{
		}

		public void OnGoldenTickedClicked()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDataChanged(BattlePassData _)
		{
		}

		private void OnMenuStackChanged()
		{
		}

		private void Refresh()
		{
		}

		public override ITutorialState? CheckState()
		{
			return null;
		}

		public override bool ShouldActivate(ITutorialState? currentState)
		{
			return false;
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
