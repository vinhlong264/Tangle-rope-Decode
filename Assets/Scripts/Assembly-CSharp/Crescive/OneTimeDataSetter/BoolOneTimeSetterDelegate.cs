using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.OneTimeDataSetter
{
	public class BoolOneTimeSetterDelegate : BaseOneTimeSetterDelegate<bool>
	{
		[SerializeField]
		private BoolVariableReference dataReference;

		protected override bool GetData()
		{
			return false;
		}
	}
}
