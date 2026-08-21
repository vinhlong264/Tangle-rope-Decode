using System.Runtime.InteropServices;

namespace Profile
{
	public class ProfileEvents
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnProfileDataChanged : IEvent
		{
		}
	}
}
