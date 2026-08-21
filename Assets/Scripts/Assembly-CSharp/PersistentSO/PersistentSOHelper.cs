using System;
using System.Collections.Generic;

namespace PersistentSO
{
	public static class PersistentSOHelper
	{
		public static string SaveFolderPath => null;

		public static void CreateDirectoryIfNotExist()
		{
		}

		public static bool ExistsAny()
		{
			return false;
		}

		public static List<Guid> GetAllFileNames()
		{
			return null;
		}

		public static bool FileExists(string name)
		{
			return false;
		}

		public static string GetSavePath(string name)
		{
			return null;
		}

		public static void Clear(string name)
		{
		}

		public static void ClearAll()
		{
		}

		public static T Save<T>(string name, T value)
		{
			return default(T);
		}

		public static T SaveOriginal<T>(string name, T value)
		{
			return default(T);
		}

		public static T Load<T>(string name, T initialValue)
		{
			return default(T);
		}

		public static T LoadOriginal<T>(string name, T initialValue)
		{
			return default(T);
		}

		public static object Load(string name, object initialValue, Type type)
		{
			return null;
		}

		public static object LoadOriginal(string name, object initialValue, Type type)
		{
			return null;
		}

		public static string LoadJson<T>(string name, T initialValue)
		{
			return null;
		}

		public static string LoadJson(string name)
		{
			return null;
		}

		public static string LoadJsonOriginal(string name)
		{
			return null;
		}

		public static void SaveJson(string name, string json)
		{
		}

		public static void SaveJsonOriginal(string name, string json)
		{
		}

		public static Dictionary<string, string> GetAllSaveData()
		{
			return null;
		}

		public static void ClearNotExistings(List<string> keys)
		{
		}
	}
}
