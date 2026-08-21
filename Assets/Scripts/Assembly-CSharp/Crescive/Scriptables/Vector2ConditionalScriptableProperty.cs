using Crescive.HelperTypes;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Scriptables
{
	[CreateAssetMenu(fileName = "Color Conditional Scriptable Property", menuName = "Crescive/Scriptables/Property/Conditional/Color Conditional Scriptable Property")]
	public class Vector2ConditionalScriptableProperty : ConditionalScriptableProperty<Vector2, Vector2Pair, Vector2Constant, Vector2Variable, Vector2Event, Vector2PairEvent, Vector2Vector2Function, Vector2VariableInstancer, Vector2Reference, PersistentVector2Variable, Vector2ScriptableProperty, Vector2ConditionalScriptableProperty, Vector2VariableReference, Vector2ConditionVariableReferencePair>
	{
	}
}
