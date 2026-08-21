using System;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.HelperTypes
{
	[Serializable]
	public class Vector2SettableVariableReference : SettableVariableReference<Vector2, Vector2Pair, Vector2Constant, Vector2Variable, Vector2Event, Vector2PairEvent, Vector2Vector2Function, Vector2VariableInstancer, PersistentVector2Variable, Vector2SettableScriptableProperty>
	{
	}
}
