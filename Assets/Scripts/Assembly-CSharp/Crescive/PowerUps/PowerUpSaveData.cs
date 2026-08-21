using System;

namespace Crescive.PowerUps
{
	[Serializable]
	public class PowerUpSaveData : ICloneable
	{
		public bool IsSelected;

		public bool DidClaimFirstTime;

		public bool DidUseOnce;

		public PowerUpSaveData(bool isSelected, bool didClaimFirstTime, bool didUseOnce)
		{
		}

		public PowerUpSaveData(PowerUpSaveData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
