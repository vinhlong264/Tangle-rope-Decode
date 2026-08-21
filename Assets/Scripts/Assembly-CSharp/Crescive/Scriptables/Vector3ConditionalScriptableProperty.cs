using Crescive.HelperTypes;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Scriptables
{
	[CreateAssetMenu(fileName = "Vector3 Conditional Scriptable Property", menuName = "Crescive/Scriptables/Property/Conditional/Vector3 Conditional Scriptable Property")]
	public class Vector3ConditionalScriptableProperty : ConditionalScriptableProperty<Vector3, Vector3Pair, Vector3Constant, Vector3Variable, Vector3Event, Vector3PairEvent, Vector3Vector3Function, Vector3VariableInstancer, Vector3Reference, PersistentVector3Variable, Vector3ScriptableProperty, Vector3ConditionalScriptableProperty, Vector3VariableReference, Vector3ConditionVariableReferencePair>
	{
	}
}
