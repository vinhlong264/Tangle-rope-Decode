using Crescive.GameStates;
using Crescive.HelperTypes;
using CresciveCore;
using CresciveCore.Utils;
using PersistentSO;
using UnityEngine;

namespace Crescive
{
	[DefaultExecutionOrder(-999999)]
	public class AutoLevelSaverManager : Singleton<AutoLevelSaverManager>
	{
		[SerializeField]
		private GameStateEvents gameStateEvents;

		[SerializeField]
		private LoaderChannel loaderChannel;

		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private PersistentBoolVariable isLastCompletedLevelMustSave;

		[SerializeField]
		private BoolVariableReference levelTypeCondition;

		private bool isGameWin;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected override void OnInstanceCreated()
		{
		}

		private void OnGameStarted()
		{
		}

		private void OnGameWin()
		{
		}

		private void OnLevelLoaded(LevelData _)
		{
		}

		private void OnLoadingHomeStarted()
		{
		}

		private void SetIsLastCompletedLevelMustSave(bool state)
		{
		}

		private void TryUpdateSavedLevelNumberOnAppStart()
		{
		}
	}
}
