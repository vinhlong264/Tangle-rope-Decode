using System;
using UnityEngine.Localization;

namespace Crescive.Localization
{
	[Serializable]
	public class StringLocalizationKey
	{
		public bool useTable;

		public string plainValue;

		public LocalizedString tableValue;

		public string Value => null;

		public static implicit operator string(StringLocalizationKey field)
		{
			return null;
		}
	}
}
