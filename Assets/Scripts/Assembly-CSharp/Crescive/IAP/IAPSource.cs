using System.Runtime.Serialization;

namespace Crescive.IAP
{
	public enum IAPSource
	{
		[EnumMember(Value = "store")]
		Shop = 0,
		[EnumMember(Value = "pop-up")]
		PopUp = 1,
		[EnumMember(Value = "other")]
		OTHER = 2,
		[EnumMember(Value = "ego")]
		EGO = 3
	}
}
