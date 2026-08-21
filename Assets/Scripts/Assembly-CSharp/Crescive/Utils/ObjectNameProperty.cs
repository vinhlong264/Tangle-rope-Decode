using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.Utils
{
	public class ObjectNameProperty : StringScriptableProperty
	{
		[SerializeField]
		private Object asset;

		protected override string GetValue()
		{
			return null;
		}
	}
}
