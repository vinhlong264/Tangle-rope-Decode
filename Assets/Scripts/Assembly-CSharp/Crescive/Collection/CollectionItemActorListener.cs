using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Crescive.Collection
{
	public class CollectionItemActorListener : MonoBehaviour
	{
		[FormerlySerializedAs("shopItemActor")]
		[SerializeField]
		private BaseCollectionItemActor collectionItemActor;

		[SerializeField]
		private UnityEvent OnItemChanged;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
