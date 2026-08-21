using Crescive.TwistedTangle;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.CreatorMode
{
	public class RopesScaleUpdater : MonoBehaviour
	{
		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private FloatVariable currentMultiplier;

		public void UpdateRopeWidth(RopeEntity rope)
		{
		}

		public void UpdateAllRopeWidths()
		{
		}

		public void ResetAllRopeWidths()
		{
		}
	}
}
