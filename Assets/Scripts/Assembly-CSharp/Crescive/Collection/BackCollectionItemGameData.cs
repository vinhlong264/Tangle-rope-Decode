using UnityEngine;

namespace Crescive.Collection
{
	[CreateAssetMenu(fileName = "BackCollectionItemGameData", menuName = "GameData/Collection/BackCollectionItemGameData")]
	public class BackCollectionItemGameData : BaseCollectionItemGameData
	{
		[field: SerializeField]
		public Material BackMaterial { get; private set; }

		[field: SerializeField]
		public Color PinSlotColor { get; private set; }

		[field: SerializeField]
		public Color PinSlotSelectedOutlineColor { get; private set; }
	}
}
