using System;
using CresciveCore;
using UnityEngine;

namespace Stats
{
	[DefaultExecutionOrder(int.MinValue)]
	public class StatManager : MonoBehaviour
	{
		public static StatManager Instance;

		public LevelSystem LevelSystem;

		private StatDatas statDatas;

		public static StatDatas StatDatas
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private static DateTime TodayUtc => default(DateTime);

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private bool EnsureDailyRollover(ref StatDatas d)
		{
			return false;
		}

		private void Save(StatDatas d)
		{
		}

		private void OnEnable()
		{
		}

		private void OnGameLose()
		{
		}

		private void OnGameWin()
		{
		}

		private void OnDayMissed()
		{
		}

		public void OnFail()
		{
		}

		public void OnWin()
		{
		}
	}
}
