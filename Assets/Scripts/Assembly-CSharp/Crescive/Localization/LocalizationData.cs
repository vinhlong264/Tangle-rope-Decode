using System;
using System.Collections.Generic;

namespace Crescive.Localization
{
	[Serializable]
	public class LocalizationData
	{
		public List<LocaleData> Locales;

		public LocalizationData(List<LocaleData> locales)
		{
		}

		public LocalizationData(LocalizationData other)
		{
		}

		public bool IsLocaleEnabled(string locale)
		{
			return false;
		}
	}
}
