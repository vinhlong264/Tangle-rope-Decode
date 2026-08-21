using System;

namespace Crescive.DataService
{
	[Serializable]
	public class JsonField : ICloneable
	{
		public string Name;

		public string Value;

		public JsonField(string name, string value)
		{
		}

		public JsonField(JsonField other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
