using UnityEngine;

namespace Crescive.Collection.Preview
{
	public class BackPreviewCollectionItemActor : CollectionItemActor<BackCollectionItemGameData>
	{
		[SerializeField]
		private MeshRenderer backMeshRenderer;

		[SerializeField]
		private Transform slotsParent;

		protected override void OnItemSelectedInternal(BackCollectionItemGameData itemGameData)
		{
		}
	}
}
