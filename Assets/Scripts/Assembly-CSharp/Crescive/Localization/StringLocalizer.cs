using System.Collections.Generic;
using Crescive.Atom;
using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

namespace Crescive.Localization
{
	[DefaultExecutionOrder(1)]
	public class StringLocalizer : MonoBehaviour
	{
		[SerializeField]
		private bool isKeyDynamic;

		[SerializeField]
		protected LocalizedString localizedString;

		[SerializeField]
		private string dynamicKeyTableName;

		[SerializeField]
		private StringVariableTypeField variableKey;

		[SerializeField]
		private AutoTriggerMethod dynamicKeyAutoTrigger;

		public UnityEvent<string> OnLocalize;

		private static LocalizationManager LocalizationManager => null;

		private string DynamicKeyTableName => null;

		protected string DefaultDynamicKeyTableName => null;

		protected List<string> DynamicKeyTableNames => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void UpdateStringReference()
		{
		}

		private void OnVariableKeyChanged(string key)
		{
		}

		private void OnStringChanged(string value)
		{
		}

		protected virtual void OnStringChangedInternal(string value)
		{
		}

		public void SetPlainDynamicKey(string key)
		{
		}
	}
}
