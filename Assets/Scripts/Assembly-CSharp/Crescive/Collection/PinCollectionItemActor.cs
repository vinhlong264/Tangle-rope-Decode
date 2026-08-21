using Crescive.TwistedTangle;
using UnityEngine;

namespace Crescive.Collection
{
	public class PinCollectionItemActor : CollectionItemActor<PinCollectionItemGameData>
	{
		[SerializeField]
		private PinEntity pinEntity;

		[SerializeField]
		private Transform pinModelParent;

		protected override void OnItemSelectedInternal(PinCollectionItemGameData itemGameData)
		{
		}

		private void OnItemSelectedPreview()
		{
		}
	}
}
