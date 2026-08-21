using UnityEngine;

namespace PersistentSO
{
	[CreateAssetMenu(fileName = "PersistentBoolListVariable", menuName = "ScriptableObjects/Persistent/PersistentBoolListVariable")]
	public class PersistentBoolListVariable : PersistentListVariable<bool>
	{
		public override bool GetItemCopy(bool item)
		{
			return false;
		}
	}
}
