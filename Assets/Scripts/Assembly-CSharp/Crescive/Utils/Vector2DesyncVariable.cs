using Crescive.HelperTypes;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Utils
{
	[CreateAssetMenu(fileName = "Vector2 Desync Variable", menuName = "Crescive/Scriptables/Desync Variable/Vector2 Desync Variable")]
	public class Vector2DesyncVariable : DesyncVariable<Vector2, Vector2Pair, Vector2Constant, Vector2Variable, Vector2Event, Vector2PairEvent, Vector2Vector2Function, Vector2VariableInstancer, PersistentVector2Variable, Vector2SettableScriptableProperty, Vector2SettableVariableReference>
	{
	}
}
