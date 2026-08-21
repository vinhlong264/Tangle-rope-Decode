using UnityEngine;

namespace PersistentSO
{
	[CreateAssetMenu(fileName = "PersistentIntListVariable", menuName = "ScriptableObjects/Persistent/PersistentIntListVariable")]
	public class PersistentIntListVariable : PersistentListVariable<int>
	{
		public override int GetItemCopy(int item)
		{
			return 0;
		}
	}
}
