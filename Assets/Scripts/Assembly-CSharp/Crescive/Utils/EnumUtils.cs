using System;
using System.Collections.Generic;

namespace Crescive.Utils
{
	public static class EnumUtils
	{
		public static List<string> GetDescriptions<TEnum>() where TEnum : Enum
		{
			return null;
		}

		public static TEnum GetFromDescription<TEnum>(string description) where TEnum : Enum
		{
			return default(TEnum);
		}
	}
}
