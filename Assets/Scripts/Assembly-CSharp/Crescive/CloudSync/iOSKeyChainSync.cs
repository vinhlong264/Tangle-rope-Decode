using System.Collections.Generic;
using Crescive.GameStates;
using Crescive.PersistentSO;
using Crescive.PlayerPrefHelpers;
using UnityEngine;

namespace Crescive.CloudSync
{
	[DefaultExecutionOrder(-2147483647)]
	public class iOSKeyChainSync : MonoBehaviour
	{
		[SerializeField]
		private PlayerPrefList playerPrefs;

		[SerializeField]
		private GameStateEvents gameStateEvents;

		[SerializeField]
		private PersistentSystem persistentSystem;

		[SerializeField]
		private PersistentVariablesList excludedPersistentVariables;

		public static readonly string KEY;

		private readonly string HIGHEST_LEVEL_NUMBER;

		private void Awake()
		{
		}

		public static void DeleteKeyChainData()
		{
		}

		private void SyncLoad()
		{
		}

		private bool IsSaveDataValid(CloudSaveData cloudSaveData)
		{
			return false;
		}

		public void Load(string saveDataJson)
		{
		}

		public void LoadReadableData(string readableSaveDataJson)
		{
		}

		private Dictionary<string, string> GetPlayerPrefsSaveData()
		{
			return null;
		}

		public string GetAllSaveDataJson()
		{
			return null;
		}

		public string GetAllReadableSaveDataJson()
		{
			return null;
		}

		public string GetJson(DataGroups group)
		{
			return null;
		}

		private Dictionary<string, string> GetPersistentVariablesSaveData()
		{
			return null;
		}

		private Dictionary<string, string> GetReadablePersistentVariablesSaveData()
		{
			return null;
		}

		private Dictionary<string, string> GetReadablePersistentVariablesSaveData(DataGroups group)
		{
			return null;
		}

		public void SetPlayerPrefsSaveData(string json)
		{
		}

		public void SetPlayerPrefsSaveData(Dictionary<string, string> playerPrefsData)
		{
		}

		public void SetPersistentVariablesReadableSaveData(string json)
		{
		}

		public void SetPersistentVariablesReadableSaveData(Dictionary<string, string> readablePersistentVariablesData)
		{
		}

		private void SetPersistentVariablesSaveData(Dictionary<string, string> persistentVariablesData)
		{
		}

		public void CalculateAndLogSaveDataSize()
		{
		}
	}
}
