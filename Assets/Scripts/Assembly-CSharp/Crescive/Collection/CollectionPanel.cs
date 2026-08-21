using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Collection
{
	[DefaultExecutionOrder(-1)]
	public class CollectionPanel : MonoBehaviour
	{
		[SerializeField]
		private List<CollectionItemSystem> collectionItemSystems;

		[SerializeField]
		private List<CollectionItemsController> collectionItemsControllers;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
