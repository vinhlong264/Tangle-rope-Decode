using System;
using System.Collections.Generic;

namespace Crescive.DataService
{
	[Serializable]
	public class StringList : ICloneable
	{
		public List<string> List;

		public StringList(List<string> list)
		{
		}

		public StringList(StringList other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
