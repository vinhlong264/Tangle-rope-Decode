using System.Runtime.InteropServices;

namespace Stats
{
	public class StatEvents
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnGameWin : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnGameLose : IEvent
		{
		}
	}
}
