using Obi;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class RopeCollisionDataIgnoreUpdater : MonoBehaviour
	{
		[SerializeField]
		private RopeConnection ropeConnection;

		[SerializeField]
		private ObiCollisionsChannel collisionsChannel;

		[SerializeField]
		private float updateInterval;

		private float lastUpdateTime;

		private void Update()
		{
		}

		private void UpdateIgnoredGameObjects()
		{
		}
	}
}
