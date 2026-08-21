using System;
using System.Collections.Generic;

namespace Crescive.ResourceSystem.UI
{
	[Serializable]
	public class ResourceAnimationTargetGroup
	{
		public string Id;

		public List<ResourceAnimationTarget> TargetStack;

		public ResourceAnimationTargetGroup(string id)
		{
		}
	}
}
