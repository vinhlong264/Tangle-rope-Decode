using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Leveling
{
	[DefaultExecutionOrder(-1000)]
	public class LevelingResetter : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private List<LevelingDataResetData> data;

		[Header("Settings")]
		[SerializeField]
		private bool resetOnAwake;

		private void Awake()
		{
		}

		public void ResetValues()
		{
		}
	}
}
