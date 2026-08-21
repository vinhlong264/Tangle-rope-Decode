using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Crescive.LiveEvents.BattlePass
{
	[Serializable]
	public class BattlePassSettings : ICloneable
	{
		public List<BattlePassConfig> Passes;

		private List<string> PassIds => null;

		public bool HasPass(string id)
		{
			return false;
		}

		[SpecialName]
		private List<string> GetPassIds()
		{
			return null;
		}

		public object Clone()
		{
			return null;
		}

		public BattlePassConfig FindPassById(string id)
		{
			return null;
		}

		public bool IsPassValid(string id)
		{
			return false;
		}

		public BattlePassConfig GetAvailablePass(string id)
		{
			return null;
		}

		public BattlePassConfig GetPass(string id)
		{
			return null;
		}

		public BattlePassSettings()
		{
		}

		public BattlePassSettings(BattlePassSettings other)
		{
		}

		public BattlePassSettings(List<BattlePassConfig> passes)
		{
		}
	}
}
