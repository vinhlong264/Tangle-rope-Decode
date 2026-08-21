using System;
using Crescive.Command;
using Crescive.CreatorMode;

namespace Crescive.TwistedTangle.Commands
{
	[Serializable]
	public class UpdateLevelCommand : ICommand
	{
		private LevelCreatorSaveData targetSaveData;

		private readonly LevelSaver levelSaver;

		private readonly LevelCreator levelCreator;

		private LevelCreatorSaveData previousSaveData;

		public UpdateLevelCommand(LevelCreatorSaveData targetSaveData, LevelSaver levelSaver, LevelCreator levelCreator)
		{
		}

		public void Execute()
		{
		}

		public void Undo()
		{
		}
	}
}
