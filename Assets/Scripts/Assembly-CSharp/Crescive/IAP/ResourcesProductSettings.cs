using System.Collections.Generic;
using UnityEngine;

namespace Crescive.IAP
{
	[CreateAssetMenu(fileName = "ResourcesProductSettings", menuName = "Crescive/Shop/Resolvers/Resources/Resources Product Settings")]
	public class ResourcesProductSettings : ScriptableObject
	{
		[field: SerializeField]
		public List<ResourceProductInfo> ResourceProductInfos { get; private set; }

		private void Add()
		{
		}

		public ResourceProductInfo GetResourceProductInfo(string packId)
		{
			return null;
		}
	}
}
