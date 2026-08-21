using System;
using UnityAtoms.BaseAtoms;
using UnityEngine.Events;

namespace Crescive.Levels
{
	[Serializable]
	public class LevelDifficultyEventPair
	{
		public StringConstant Difficulty;

		public StringConstant LevelType;

		public UnityEvent Event;

		public UnityEvent EventNotMatch;

		public UnityEvent<bool> EventDidMatch;

		public UnityEvent<bool> EventDidMatchReversed;
	}
}
