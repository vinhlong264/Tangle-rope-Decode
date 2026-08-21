using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ByteTyper
{
	public class GeneralManager : MonoBehaviour
	{
		public const string VersionsFileName = "ByteTyperVersions";

		public const string VersionsFilePath = "Assets/Resources/ByteTyperVersions.json";

		private static GeneralManager m_Instance;

		private int m_ScreenShotIndex;

		private static bool m_Destroyed;

		public static ByteTyperVersions Versions { get; private set; }

		public static GeneralManager Instance => null;

		public static string VersionFullText => null;

		public string SavePath => null;

		public long Money { get; private set; }

		public event Action OnMoneyUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void OnApplicationFocus(bool focus)
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		static GeneralManager()
		{
		}

		public void Initialize()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Init()
		{
		}

		public static void ReadVersionsFile()
		{
		}

		public static void WriteVersionsFile(string version, int gameVersion, int iOSBuild)
		{
		}

		public static void PauseGame()
		{
		}

		public static void ResumeGame()
		{
		}

		public static void FastGame()
		{
		}

		public static bool IsGamePaused()
		{
			return false;
		}
	}
}
