using System;
using System.Collections.Generic;

namespace Crescive.CloudSync
{
	[Serializable]
	public class SaveData
	{
		public Dictionary<string, string> Data;

		public SaveData(Dictionary<string, string> data)
		{
		}
	}
}
