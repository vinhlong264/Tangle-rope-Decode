using Crescive.HelperTypes;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Utils
{
	[CreateAssetMenu(fileName = "Int Desync Variable", menuName = "Crescive/Scriptables/Desync Variable/Int Desync Variable")]
	public class IntDesyncVariable : DesyncVariable<int, IntPair, IntConstant, IntVariable, IntEvent, IntPairEvent, IntIntFunction, IntVariableInstancer, PersistentIntVariable, IntSettableScriptableProperty, IntSettableVariableReference>
	{
	}
}
