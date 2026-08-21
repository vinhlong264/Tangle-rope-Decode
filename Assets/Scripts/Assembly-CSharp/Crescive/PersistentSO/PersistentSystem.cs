using System.Collections.Generic;
using PersistentSO;
using UnityEngine;

namespace Crescive.PersistentSO
{
	[CreateAssetMenu(fileName = "PersistentSystem", menuName = "Crescive/Persistent/PersistentSystem")]
	public class PersistentSystem : ScriptableObject
	{
		[SerializeField]
		private List<BasePersistentVariable> variables;

		public List<string> Names => null;

		public List<string> Keys => null;

		public List<BasePersistentVariable> Variables => null;

		public bool HasVariable(string variableName)
		{
			return false;
		}

		public bool HasVariableBySaveKey(string saveKey)
		{
			return false;
		}

		public void Save(string key, string json)
		{
		}

		public string GetVariableNameByKey(string saveKey)
		{
			return null;
		}

		public BasePersistentVariable GetVariableByName(string variableName)
		{
			return null;
		}

		public string GetVariableJsonByName(string variableName)
		{
			return null;
		}

		public Dictionary<string, string> GetAllSaveData()
		{
			return null;
		}

		public Dictionary<string, string> GetAllReadableSaveData()
		{
			return null;
		}

		public Dictionary<string, string> GetAllReadableSaveData(DataGroups group)
		{
			return null;
		}

		public Dictionary<string, string> MatchAllReadableSaveDataToSaveData(Dictionary<string, string> readableSaveData)
		{
			return null;
		}
	}
}
