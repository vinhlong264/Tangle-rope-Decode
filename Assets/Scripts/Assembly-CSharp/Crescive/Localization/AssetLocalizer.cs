using System.Collections.Generic;
using Crescive.Atom;
using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

namespace Crescive.Localization
{
	[DefaultExecutionOrder(1)]
	public abstract class AssetLocalizer<T, TL> : MonoBehaviour where T : Object where TL : LocalizedAsset<T>, new()
	{
		[SerializeField]
		private bool isKeyDynamic;

		[SerializeField]
		protected TL localizedAsset;

		[SerializeField]
		private string dynamicKeyTableName;

		[SerializeField]
		private StringVariableTypeField variableKey;

		[SerializeField]
		private AutoTriggerMethod dynamicKeyAutoTrigger;

		public UnityEvent<T> OnLocalize;

		protected static LocalizationManager LocalizationManager => null;

		protected abstract string DefaultDynamicKeyTableName { get; }

		protected abstract List<string> DynamicKeyTableNames { get; }

		private string DynamicKeyTableName => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void UpdateAssetReference()
		{
		}

		private void OnVariableKeyChanged(string key)
		{
		}

		private void OnAssetChanged(T value)
		{
		}

		protected abstract void OnAssetChangedInternal(T value);
	}
}
