using System;
using System.Collections.Generic;
using UnityEngine;

namespace Crescive.OnlineLevels
{
	[Serializable]
	public class DifficultyUpdateData
	{
		public Vector2 LevelsInterval;

		[SerializeField]
		private List<string> difficulties;

		private static List<string> DifficultyTypes => null;

		public List<string> Difficulties => null;

		private string TransformDifficulty(string difficulty)
		{
			return null;
		}

		public void SetDifficulties(IEnumerable<string> value)
		{
		}
	}
}
