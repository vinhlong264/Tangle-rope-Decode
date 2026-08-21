using Crescive.HelperTypes;
using Crescive.TwistedTangle;
using UnityEngine;

namespace Systems.ColorGameMode
{
	public class RopeNotEnoughFailScreen : MonoBehaviour
	{
		[SerializeField]
		private IntVariableReference failCount;

		[SerializeField]
		private LastLoadedLevelTrackData lastLoadedLevelTrackData;

		private int playingTotalLevelNumber;

		private int offerStage
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		public void OnUndoMove()
		{
		}

		public void OnUndoPurchased()
		{
		}
	}
}
