using Crescive.Scriptables;
using UnityEngine;

namespace ElephantSDK
{
	[CreateAssetMenu(fileName = "TotalSessionCountProperty", menuName = "ElephantSDK/App/Properties/TotalSessionCountProperty")]
	public class TotalSessionCountProperty : IntScriptableProperty
	{
		protected override int GetValue()
		{
			return 0;
		}
	}
}
