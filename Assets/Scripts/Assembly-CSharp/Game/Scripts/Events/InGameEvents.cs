using Crescive.TwistedTangle;

namespace Game.Scripts.Events
{
	public class InGameEvents
	{
		public struct RopeMergedEvent : IEvent
		{
			public RopeEntity RopeEntity;

			public RopeMergedEvent(RopeEntity ropeEntity1)
			{
				RopeEntity = null;
			}
		}
	}
}
