using Crescive.Channels;
using Crescive.TwistedTangle;
using UnityEngine;

namespace Crescive.CreatorMode
{
	[CreateAssetMenu(fileName = "LevelCreatorChannel", menuName = "Crescive/CreatorMode/LevelCreatorChannel")]
	public class LevelCreatorChannel : ObjectChannel<LevelCreator>
	{
	}
}
