using UnityEngine;

namespace PersistentSO
{
	[CreateAssetMenu(fileName = "PersistentColorList", menuName = "ScriptableObjects/Persistent/PersistentColorList")]
	public class PersistentColorList : PersistentListVariable<Color>
	{
		public override Color GetItemCopy(Color item)
		{
			return default(Color);
		}
	}
}
