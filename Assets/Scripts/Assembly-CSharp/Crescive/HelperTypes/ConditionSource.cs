using System;
using PersistentSO;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.HelperTypes
{
	[Serializable]
	public class ConditionSource
	{
		[SerializeField]
		private ConditionSourceType conditionSourceType;

		[SerializeField]
		private PersistentBoolVariable persistentBool;

		[SerializeField]
		private BoolReference atomReferenceBool;

		[SerializeField]
		private AtomCondition atomCondition;

		public bool Condition => false;
	}
}
