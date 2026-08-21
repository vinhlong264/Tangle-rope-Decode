using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Utils
{
	public class DesyncVariablesSetup : MonoBehaviour
	{
		[SerializeField]
		private List<BaseDesyncVariable> desyncVariables;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
