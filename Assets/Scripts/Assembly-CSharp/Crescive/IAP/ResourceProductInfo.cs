using System;
using Crescive.ResourceSystem;
using UnityEngine;

namespace Crescive.IAP
{
	[Serializable]
	public class ResourceProductInfo
	{
		[field: SerializeField]
		public string ProductPackId { get; private set; }

		[field: SerializeField]
		public ResourceChannel Channel { get; private set; }
	}
}
