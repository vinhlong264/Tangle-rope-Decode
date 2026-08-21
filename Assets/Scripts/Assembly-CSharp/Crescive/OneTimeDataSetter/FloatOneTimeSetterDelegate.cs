using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.OneTimeDataSetter
{
	public class FloatOneTimeSetterDelegate : BaseOneTimeSetterDelegate<float>
	{
		[SerializeField]
		private FloatVariableReference dataReference;

		protected override float GetData()
		{
			return 0f;
		}
	}
}
