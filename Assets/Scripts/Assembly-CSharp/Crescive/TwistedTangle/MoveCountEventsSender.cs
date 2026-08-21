using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class MoveCountEventsSender : MonoBehaviour
	{
		[SerializeField]
		private CresciveEventSender eventSender;

		[SerializeField]
		private IntVariable totalMoveCount;

		public void SendMoveCountEvent()
		{
		}
	}
}
