using Crescive.Collection;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class CollectionEventsSender : MonoBehaviour
	{
		[SerializeField]
		private CresciveEventSender eventSender;

		[SerializeField]
		private StringVariable sceneTypeId;

		private string SceneTypeId => null;

		public void OnCollectionOpened()
		{
		}

		public void OnCollectionItemPurchasedWithId(string itemId)
		{
		}

		public void OnCollectionItemOfferedWithId(string itemId)
		{
		}

		public void OnCollectionItemEquipped(CollectionItemEquipArgs itemEquipArgs)
		{
		}
	}
}
