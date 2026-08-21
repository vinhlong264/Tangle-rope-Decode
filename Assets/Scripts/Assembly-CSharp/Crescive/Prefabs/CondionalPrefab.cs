using System;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.Prefabs
{
	[Serializable]
	public struct CondionalPrefab
	{
		public BoolVariableReference condition;

		public GameObject Prefab;
	}
}
