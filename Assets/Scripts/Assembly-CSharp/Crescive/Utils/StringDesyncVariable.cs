using Crescive.HelperTypes;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Utils
{
	[CreateAssetMenu(fileName = "String Desync Variable", menuName = "Crescive/Scriptables/Desync Variable/String Desync Variable")]
	public class StringDesyncVariable : DesyncVariable<string, StringPair, StringConstant, StringVariable, StringEvent, StringPairEvent, StringStringFunction, StringVariableInstancer, PersistentStringVariable, StringSettableScriptableProperty, StringSettableVariableReference>
	{
	}
}
