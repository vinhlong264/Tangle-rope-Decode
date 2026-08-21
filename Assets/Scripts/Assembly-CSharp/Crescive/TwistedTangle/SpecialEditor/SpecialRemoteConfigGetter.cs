using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	[CreateAssetMenu(fileName = "RemoteConfigGetter", menuName = "Special Editor/Remote Config Getter")]
	public class SpecialRemoteConfigGetter : ScriptableObject
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

		private JObject GetRemoteConfigJObject()
		{
			return null;
		}

		private static bool IsValidJson(string str)
		{
			return false;
		}

		private string RemoveNonAsciiCharacters(string input)
		{
			return null;
		}

		public string GetValuesByKeys(List<string> keys)
		{
			return null;
		}

		public string GetValueByExlcudedKeys(List<string> keys)
		{
			return null;
		}

		public List<string> GetKeys()
		{
			return null;
		}

		public string GetValueByKey(string key)
		{
			return null;
		}
	}
}
