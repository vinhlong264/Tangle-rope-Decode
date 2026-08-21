using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Collection
{
	[CreateAssetMenu(fileName = "CollectionItemSystemsGroup", menuName = "Crescive/Collection/CollectionItemSystemsGroup")]
	public class CollectionItemSystemsGroup : ScriptableObject
	{
		[SerializeField]
		private List<CollectionItemSystem> systems;

		public List<CollectionItemSystem> Systems => null;
	}
}
