using Crescive.CreatorMode;
using JetBrains.Annotations;
using UnityEngine;

namespace Crescive.Levels
{
	public class LoadedLevelData : MonoBehaviour
	{
		[CanBeNull]
		public LevelCreatorSaveData LevelData { get; set; }
	}
}
