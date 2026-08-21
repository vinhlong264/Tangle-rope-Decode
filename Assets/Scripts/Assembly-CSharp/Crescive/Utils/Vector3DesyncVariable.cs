using Crescive.HelperTypes;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Utils
{
	[CreateAssetMenu(fileName = "Vector3 Desync Variable", menuName = "Crescive/Scriptables/Desync Variable/Vector3 Desync Variable")]
	public class Vector3DesyncVariable : DesyncVariable<Vector3, Vector3Pair, Vector3Constant, Vector3Variable, Vector3Event, Vector3PairEvent, Vector3Vector3Function, Vector3VariableInstancer, PersistentVector3Variable, Vector3SettableScriptableProperty, Vector3SettableVariableReference>
	{
	}
}
