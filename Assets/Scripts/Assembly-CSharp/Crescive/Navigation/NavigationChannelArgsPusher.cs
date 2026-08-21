using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Navigation
{
	public class NavigationChannelArgsPusher : MonoBehaviour
	{
		[SerializeField]
		private NavigationChannel navigationChannel;

		[SerializeField]
		private StringReference navigatableId;

		[SerializeField]
		private Object args;

		public void Push()
		{
		}
	}
}
