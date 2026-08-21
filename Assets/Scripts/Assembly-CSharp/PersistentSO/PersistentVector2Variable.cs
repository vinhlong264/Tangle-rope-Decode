using UnityEngine;

namespace PersistentSO
{
	[CreateAssetMenu(fileName = "PersistentVector2Variable", menuName = "ScriptableObjects/Persistent/PersistentVector2Variable")]
	public class PersistentVector2Variable : PersistentVariable<Vector2>
	{
		public override Vector2 GetCopy(Vector2 value)
		{
			return default(Vector2);
		}
	}
}
