using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Collection
{
	public class CollectionItemSystemsGroupEquipListener : MonoBehaviour
	{
		[SerializeField]
		private CollectionItemSystemsGroup collectionItemSystemsGroup;

		public UnityEvent<CollectionItemEquipArgs> OnItemEquipped;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
