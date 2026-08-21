using Crescive.Channels;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[CreateAssetMenu(fileName = "RopeChannel", menuName = "GameData/Map/Channels/Rope Channel")]
	public class RopeChannel : ObjectChannel<RopeEntity>
	{
		public void HighlightRope()
		{
		}

		public void StopHighlighting()
		{
		}
	}
}
