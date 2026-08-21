using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

namespace Crescive.Localization
{
	[Serializable]
	public class LocalizationDataServiceLocaleSelector : IStartupLocaleSelector
	{
		[SerializeField]
		private LocalizationDataService localizationDataService;

		[SerializeField]
		private LocaleIdentifier defaultLocaleId;

		public Locale GetStartupLocale(ILocalesProvider availableLocales)
		{
			return null;
		}

		private bool IsLocaleEnabled(Locale locale)
		{
			return false;
		}

		private CultureInfo GetSystemCulture()
		{
			return null;
		}

		private SystemLanguage GetApplicationSystemLanguage()
		{
			return default(SystemLanguage);
		}
	}
}
