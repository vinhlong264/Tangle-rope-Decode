using Crescive.TwistedTangle.Channel;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class RopeKeyToggleController : BaseRopeSelectToggler
	{
		[SerializeField]
		private KeyEntity keyEntityPrefab;

		[SerializeField]
		private KeysChannel keysChannel;

		protected override void OnHitRope(RopeRaycastData ropeRaycastData)
		{
		}

		private void DestroyRopeKey(RopeEntity ropeEntity)
		{
		}

		private void CreateKey(RopeEntity ropeEntity, Vector3 point)
		{
		}
	}
}
