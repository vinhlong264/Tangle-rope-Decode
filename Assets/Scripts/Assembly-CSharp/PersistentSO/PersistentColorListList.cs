using UnityEngine;

namespace PersistentSO
{
	[CreateAssetMenu(fileName = "PersistentColorListList", menuName = "ScriptableObjects/Persistent/PersistentColorListList")]
	public class PersistentColorListList : PersistentListVariable<ColorListStruct>
	{
		public override ColorListStruct GetItemCopy(ColorListStruct item)
		{
			return default(ColorListStruct);
		}
	}
}
