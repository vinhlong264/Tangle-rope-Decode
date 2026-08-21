using System;
using System.Collections.Generic;

namespace Crescive.CloudSync
{
	[Serializable]
	public class CloudSaveData
	{
		public Dictionary<string, string> PlayerPrefsData;

		public Dictionary<string, string> PersistentVariablesData;

		public CloudSaveData(Dictionary<string, string> playerPrefsData, Dictionary<string, string> persistentVariablesData)
		{
		}
	}
}
