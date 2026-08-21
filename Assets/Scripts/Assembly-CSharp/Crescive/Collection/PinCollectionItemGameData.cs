using UnityEngine;

namespace Crescive.Collection
{
	[CreateAssetMenu(fileName = "PinCollectionItemGameData", menuName = "GameData/Collection/PinCollectionItemGameData")]
	public class PinCollectionItemGameData : BaseCollectionItemGameData
	{
		[field: SerializeField]
		public GameObject PinModel { get; private set; }
	}
}
