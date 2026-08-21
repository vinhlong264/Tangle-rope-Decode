using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Utils
{
	public class StringSelector : MonoBehaviour
	{
		[SerializeField]
		private List<StringVariableReference> variables;

		public UnityEvent<string> OnSelect;

		public void SelectString(int index)
		{
		}
	}
}
