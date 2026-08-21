using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Crescive.ResourceSystem
{
	public class ResourceGeneratorDataServiceWrapper : ResourceGeneratorDataProviderWrapper
	{
		[SerializeField]
		private ResourceGeneratorDataService resourceGeneratorDataService;

		public override event Action Changed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override ResourceGeneratorData GetData()
		{
			return null;
		}

		public override void GetSync()
		{
		}
	}
}
