using Crescive.HelperTypes;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Utils
{
	[CreateAssetMenu(fileName = "Bool Desync Variable", menuName = "Crescive/Scriptables/Desync Variable/Bool Desync Variable")]
	public class BoolDesyncVariable : DesyncVariable<bool, BoolPair, BoolConstant, BoolVariable, BoolEvent, BoolPairEvent, BoolBoolFunction, BoolVariableInstancer, PersistentBoolVariable, BoolSettableScriptableProperty, BoolSettableVariableReference>
	{
	}
}
