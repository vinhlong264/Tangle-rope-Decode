using System;

namespace Crescive.Localization
{
	[Serializable]
	public class LocaleData : ICloneable
	{
		public string Code;

		public bool Enabled;

		public LocaleData(string code, bool enabled)
		{
		}

		public LocaleData(LocaleData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
