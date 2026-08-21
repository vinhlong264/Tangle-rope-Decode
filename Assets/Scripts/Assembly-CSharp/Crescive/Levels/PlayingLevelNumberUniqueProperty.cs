using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.Levels
{
	[CreateAssetMenu(fileName = "PlayingLevelNumberUniqueProperty", menuName = "Crescive/Levels/PlayingLevelNumberUniqueProperty", order = 0)]
	public class PlayingLevelNumberUniqueProperty : IntScriptableProperty
	{
		protected override int GetValue()
		{
			return 0;
		}
	}
}
