using Crescive.TwistedTangle;
using UnityEngine;

namespace Crescive.Collection
{
	public class RopeCollectionItemActor : CollectionItemActor<RopeCollectionItemGameData>
	{
		[SerializeField]
		private RopeEntity ropeEntity;

		[SerializeField]
		private Transform ropeModelControllerParent;

		protected override void OnItemSelectedInternal(RopeCollectionItemGameData itemGameData)
		{
		}
	}
}
