using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.Navigation
{
	[CreateAssetMenu(fileName = "Navigation Stack Count Scriptable Property", menuName = "Crescive/Navigation/Navigation Stack Count Scriptable Property")]
	public class NavigationStackCountScriptableProperty : IntScriptableProperty
	{
		[SerializeField]
		private NavigationChannel navigationChannel;

		protected override int GetValue()
		{
			return 0;
		}
	}
}
