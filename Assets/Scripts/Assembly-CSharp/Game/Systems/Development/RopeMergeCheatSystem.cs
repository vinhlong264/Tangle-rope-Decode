using Crescive.TwistedTangle;
using Obi;
using UnityEngine;

namespace Game.Systems.Development
{
	[CreateAssetMenu(fileName = "RopeMergeCheatSystem", menuName = "GameData/Development/RopeMergeCheatSystem")]
	public class RopeMergeCheatSystem : ScriptableObject
	{
		[Header("References")]
		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private ObiCollisionsChannel collisionsChannel;

		public void MergeAllRopes()
		{
		}

		private void TryTearRope(RopeEntity rope)
		{
		}

		private void WakeUpAllSleepingRopes()
		{
		}
	}
}
