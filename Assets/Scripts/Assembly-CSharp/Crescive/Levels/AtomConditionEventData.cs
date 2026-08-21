using System;
using System.Collections.Generic;
using UnityAtoms;
using UnityEngine.Events;

namespace Crescive.Levels
{
	[Serializable]
	public class AtomConditionEventData
	{
		public List<AtomCondition> Conditions;

		public UnityEvent OnTrue;

		public UnityEvent OnFalse;

		public UnityEvent<bool> OnIsTrue;

		public UnityEvent<bool> OnIsFalse;
	}
}
