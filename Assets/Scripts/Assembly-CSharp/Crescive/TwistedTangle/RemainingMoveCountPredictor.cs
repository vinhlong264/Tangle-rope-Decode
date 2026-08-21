using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class RemainingMoveCountPredictor : MonoBehaviour
	{
		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private bool autoUpdate;

		[SerializeField]
		private IntVariable predictedRemainingMoveCount;

		[SerializeField]
		private float multiplierByContactCount;

		[SerializeField]
		private float updatePeriod;

		private float lastUpdateTime;

		private void Update()
		{
		}

		public void UpdatedPredictedRemainingMoveCount()
		{
		}
	}
}
