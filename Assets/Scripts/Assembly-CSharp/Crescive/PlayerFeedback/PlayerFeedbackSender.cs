using System;
using System.Collections.Generic;
using Crescive.Logger;
using Crescive.Scriptables;
using CresciveCore;
using Newtonsoft.Json.Linq;
using PersistentSO;
using UnityAtoms;
using UnityEngine;

namespace Crescive.PlayerFeedback
{
	[CreateAssetMenu(fileName = "PlayerFeedbackSender", menuName = "Crescive/Analytics/Player Feedback/PlayerFeedbackSender")]
	public class PlayerFeedbackSender : ScriptableObject
	{
		[Serializable]
		private class RemoteParameters
		{
			public List<string> keys;

			public List<string> values;
		}

		[Serializable]
		private class ConfigResponse
		{
			public string tag;

			public RemoteParameters data;
		}

		[SerializeField]
		private LogsDataChannel logsDataChannel;

		[SerializeField]
		private bool includeRemoteConfigs;

		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private List<AtomBaseVariable> variablesToInclude;

		[SerializeField]
		private List<BasePersistentVariable> persistentsToInclude;

		[SerializeField]
		private List<BaseScriptableProperty> propertiesToInclude;

		private static bool IsValidJson(string str)
		{
			return false;
		}

		private string GetFeedbackJson(bool encrypt)
		{
			return null;
		}

		private bool TryGetRemoteConfigJObject(out JObject jRemoteConfig)
		{
			jRemoteConfig = null;
			return false;
		}

		private bool TryGetVariablesJObject(out JObject jVariables)
		{
			jVariables = null;
			return false;
		}

		private bool TryGetPersistentsJObject(out JObject jPersistents)
		{
			jPersistents = null;
			return false;
		}

		private bool TryGetPropertiesJObject(out JObject jProperties)
		{
			jProperties = null;
			return false;
		}

		private string EscapeURL(string url)
		{
			return null;
		}

		public void ShowHelpShift()
		{
		}

		public string GetUnencryptedFeedbackData()
		{
			return null;
		}

		public void CopyTestFeedbackData(bool encrypt)
		{
		}

		public void DecryptAndCopyFeedbackDataFromClipboard()
		{
		}

		public void SendFeedbackDataWithMail()
		{
		}
	}
}
