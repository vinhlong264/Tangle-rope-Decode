using Crescive.CreatorMode;

public class LevelEvents
{
	public struct OnStageCreated : IEvent
	{
		public int levelId;

		public OnStageCreated(int levelId)
		{
			this.levelId = 0;
		}
	}

	public struct OnStageLevelCreated : IEvent
	{
		public LevelCreatorSaveData saveData;

		public OnStageLevelCreated(LevelCreatorSaveData saveData)
		{
			this.saveData = null;
		}
	}

	public struct OnStagePreviewAnimationOver : IEvent
	{
		public LevelCreatorSaveData saveData;

		public OnStagePreviewAnimationOver(LevelCreatorSaveData saveData)
		{
			this.saveData = null;
		}
	}

	public struct OnStageLevelMapStageCleared : IEvent
	{
		public int currentStageIndex;

		public OnStageLevelMapStageCleared(int currentStageIndex)
		{
			this.currentStageIndex = 0;
		}
	}
}
