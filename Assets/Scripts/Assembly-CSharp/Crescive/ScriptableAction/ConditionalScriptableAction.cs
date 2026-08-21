using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.ScriptableAction
{
	[CreateAssetMenu(fileName = "Conditional Scriptable Action", menuName = "Crescive/Scriptables/Action/Conditional Scriptable Action")]
	public class ConditionalScriptableAction : ScriptableObject
	{
		[SerializeField]
		private List<BoolVariableReference> conditions;

		[SerializeField]
		private UnityEvent trueAction;

		[SerializeField]
		private UnityEvent falseAction;

		[SerializeField]
		private UnityEvent finallyAction;

		private bool IsConditionMet => false;

		public void Invoke()
		{
		}
	}
}
