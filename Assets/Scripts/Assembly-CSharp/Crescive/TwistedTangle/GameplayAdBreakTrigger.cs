using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class GameplayAdBreakTrigger : MonoBehaviour
	{
		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private VoidEvent triggerAdBreakEvent;

		[SerializeField]
		private FloatVariable adBreakInterval;

		[SerializeField]
		private float lastAdBreakTime;

		private void Start()
		{
		}

		public void TryTriggerAdBreak()
		{
		}

		public void ResetLastAdBreakTime()
		{
		}
	}
}
