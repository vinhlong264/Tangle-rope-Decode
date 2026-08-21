using System;

namespace Crescive.HelperTypes
{
	[Flags]
	public enum AutoTriggerMethod
	{
		Awake = 1,
		OnEnable = 2,
		Start = 4
	}
}
