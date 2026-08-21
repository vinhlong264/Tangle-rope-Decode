using UnityEngine;

namespace Crescive.UI
{
	public class CollectedItemRewardList : MonoBehaviour
	{
		[SerializeField]
		private CollectedItemListItem itemPrefab;

		[SerializeField]
		private CollectablesChannel collectablesChannel;

		[SerializeField]
		private Transform itemsParent;

		public void TrySetItems()
		{
		}
	}
}
