using System;
using CresciveCore;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plinko
{
	public class PlinkoManager : MonoBehaviour
	{
		public static PlinkoManager Instance;

		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private StringVariable Difficulty;

		private PlinkoData plinkoData;

		private PlinkoRemote plinkoRemote;

		public static PlinkoData PlinkoData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PlinkoRemote PlinkoRemote => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnGameWin()
		{
		}

		public void ResetPlinkoData()
		{
		}

		public TimeSpan GetRemainingTimeSpan()
		{
			return default(TimeSpan);
		}

		public bool IsEventAlive()
		{
			return false;
		}
	}
}
