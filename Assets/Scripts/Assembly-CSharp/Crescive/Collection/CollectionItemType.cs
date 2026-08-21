using UnityEngine;

namespace Crescive.Collection
{
	[CreateAssetMenu(fileName = "CollectionItemType", menuName = "Crescive/Collection/CollectionItemType")]
	public class CollectionItemType : ScriptableObject
	{
		[SerializeField]
		private CollectionItem collectionItemPrefab;

		public CollectionItem CollectionItemPrefab => null;
	}
}
