using Crescive.Channels;
using UnityEngine;

namespace Crescive.TwistedTangle.Channel
{
	[CreateAssetMenu(menuName = "GameData/Map/Channels/Keys Channel", fileName = "Keys Channel")]
	public class KeysChannel : ObjectsChannel<KeyEntity>
	{
		public bool HasAnyKeyAttachedToRope(RopeEntity ropeEntity)
		{
			return false;
		}

		public KeyEntity GetKeyAttachedToRope(RopeEntity ropeEntity)
		{
			return null;
		}
	}
}
