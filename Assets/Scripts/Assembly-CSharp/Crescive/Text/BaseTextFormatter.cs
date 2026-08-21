using Crescive.Localization;
using UnityEngine;

namespace Crescive.Text
{
	public abstract class BaseTextFormatter : ScriptableObject
	{
		protected static LocalizationManager LocalizationManager => null;

		public string FormatText(string text)
		{
			return null;
		}

		protected abstract string FormatTextInternal(string text);
	}
}
