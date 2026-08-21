using UnityEngine;

namespace Crescive.Collection
{
	public abstract class BaseCollectionItemGameData : ScriptableObject
	{
		[field: SerializeField]
		public Sprite Icon { get; private set; }
	}
}
