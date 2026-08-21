using System.Collections.Generic;
using PersistentSO;
using UnityEngine;

namespace Crescive.PersistentSO
{
	[CreateAssetMenu(fileName = "PersistentVariablesList", menuName = "Crescive/Persistent/PersistentVariablesList", order = 0)]
	public class PersistentVariablesList : ScriptableObject
	{
		[SerializeField]
		private List<BasePersistentVariable> variables;

		public List<BasePersistentVariable> Variables => null;
	}
}
