using System.Collections.Generic;
using System.Runtime.InteropServices;
using Crescive.CreatorMode;

namespace Systems.ColorGameMode
{
	public class ColorModeEvents
	{
		public struct OnSetColorModeTargets : IEvent
		{
			public List<LevelCreatorSaveData.ColorTargetData> colorTargetDatas;

			public OnSetColorModeTargets(List<LevelCreatorSaveData.ColorTargetData> colorTargetDatas)
			{
				this.colorTargetDatas = null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnUndoMove : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnPinSetup : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnSetupRopes : IEvent
		{
		}
	}
}
