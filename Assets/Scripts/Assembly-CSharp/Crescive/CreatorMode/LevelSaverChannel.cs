using Crescive.Channels;
using Crescive.TwistedTangle;
using UnityEngine;

namespace Crescive.CreatorMode
{
	[CreateAssetMenu(fileName = "LevelSaverChannel", menuName = "Crescive/CreatorMode/LevelSaverChannel")]
	public class LevelSaverChannel : ObjectChannel<LevelSaver>
	{
	}
}
