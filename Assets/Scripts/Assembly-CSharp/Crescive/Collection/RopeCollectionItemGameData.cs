using UnityEngine;

namespace Crescive.Collection
{
	[CreateAssetMenu(fileName = "RopeCollectionItemGameData", menuName = "GameData/Collection/RopeCollectionItemGameData")]
	public class RopeCollectionItemGameData : BaseCollectionItemGameData
	{
		[field: SerializeField]
		public RopeModelController RopeModelController { get; private set; }
	}
}
