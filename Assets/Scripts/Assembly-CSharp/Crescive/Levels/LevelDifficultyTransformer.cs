using System;
using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityAtoms;
using UnityEngine;

namespace Crescive.Levels
{
	[CreateAssetMenu(menuName = "Crescive/Levels/Level Difficulty Transformer")]
	public class LevelDifficultyTransformer : AtomFunction<string, string>
	{
		[Serializable]
		public class DifficultyTransformData
		{
			public List<StringVariableReference> difficulty;

			public StringVariableReference transformedDifficulty;

			public bool HasDifficulty(string diff)
			{
				return false;
			}
		}

		[SerializeField]
		private List<DifficultyTransformData> transformData;

		public override string Call(string difficulty)
		{
			return null;
		}
	}
}
