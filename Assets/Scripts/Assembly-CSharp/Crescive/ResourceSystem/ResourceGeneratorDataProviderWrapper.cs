using System;
using UnityEngine;

namespace Crescive.ResourceSystem
{
	public abstract class ResourceGeneratorDataProviderWrapper : ScriptableObject
	{
		public abstract event Action Changed;

		public abstract ResourceGeneratorData GetData();

		public abstract void GetSync();
	}
}
