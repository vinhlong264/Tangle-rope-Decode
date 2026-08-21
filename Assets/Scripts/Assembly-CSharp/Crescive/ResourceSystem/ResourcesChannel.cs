using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.ResourceSystem
{
	[CreateAssetMenu(fileName = "Resources Channel", menuName = "Crescive/Resource System/Channels/Resources Channel")]
	public class ResourcesChannel : ScriptableObject
	{
		[SerializeField]
		private List<ResourceChannel> resources;

		public ResourceChannel GetResource(string typeId)
		{
			return null;
		}

		public ResourceChannel GetResource(StringConstant typeId)
		{
			return null;
		}

		public ResourceChannel GetResource(ProductType productType)
		{
			return null;
		}
	}
}
