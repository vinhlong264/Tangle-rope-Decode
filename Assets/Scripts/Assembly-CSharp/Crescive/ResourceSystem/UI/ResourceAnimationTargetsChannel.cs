using System.Collections.Generic;
using UnityEngine;

namespace Crescive.ResourceSystem.UI
{
	[CreateAssetMenu(fileName = "Resource Animation Targets Channel", menuName = "Crescive/Resource System/Channels/Resource Animation Targets Channel")]
	public class ResourceAnimationTargetsChannel : ScriptableObject
	{
		[SerializeField]
		private List<ResourceAnimationTargetGroup> targetGroups;

		public bool IsCurrentTarget(ResourceAnimationTarget target)
		{
			return false;
		}

		private ResourceAnimationTargetGroup GetTargetGroup(string id)
		{
			return null;
		}

		private ResourceAnimationTargetGroup AddNewTargetGroup(string id)
		{
			return null;
		}

		public void AddTarget(ResourceAnimationTarget target)
		{
		}

		public void RemoveTarget(ResourceAnimationTarget target)
		{
		}
	}
}
