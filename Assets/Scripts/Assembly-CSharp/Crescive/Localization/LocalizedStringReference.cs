using System;
using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Localization;

namespace Crescive.Localization
{
	[Serializable]
	public class LocalizedStringReference
	{
		[SerializeField]
		private bool dynamicLocalization;

		[SerializeField]
		private LocalizedString localizedString;

		[SerializeField]
		private string dynamicLocalizedStringTable;

		[SerializeField]
		private StringSettableVariableReference dynamicLocalizedStringKey;

		private static LocalizationManager LocalizationManager => null;

		private List<string> LocalizedStringTableNames => null;

		private bool IsStaticLocalizated => false;

		private bool IsDynamicLocalizated => false;

		public string Value => null;

		public void Subscribe(LocalizedString.ChangeHandler changeHandler)
		{
		}

		public void Unsubscribe(LocalizedString.ChangeHandler changeHandler)
		{
		}

		private void SetLocalizedStringKey(string key)
		{
		}
	}
}
