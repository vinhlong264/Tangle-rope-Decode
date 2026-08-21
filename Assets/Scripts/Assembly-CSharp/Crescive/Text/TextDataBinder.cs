using System.Collections.Generic;
using Crescive.Localization;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Localization;

namespace Crescive.Text
{
	[DefaultExecutionOrder(-1)]
	public class TextDataBinder : MonoBehaviour
	{
		[SerializeField]
		[Header("References")]
		private TextDataBinderRendererType rendererType;

		[SerializeField]
		private TMP_Text tmp;

		[SerializeField]
		private Text3DBehaviour text3D;

		[SerializeField]
		private List<TMP_Text> tmps;

		[SerializeField]
		[Header("Settings")]
		private bool manualUpdate;

		[SerializeField]
		private bool isLocalized;

		[SerializeField]
		private bool dynamicLocalization;

		[SerializeField]
		private LocalizedString localizedString;

		[SerializeField]
		private string dynamicLocalizedStringTable;

		[SerializeField]
		private StringReference dynamicLocalizedStringKey;

		[SerializeField]
		private bool localizeFont;

		[SerializeField]
		private string localizationFontMaterialKey;

		//private LocalizedTmpFont localizedFont;

		private bool didSetFontOnce;

		[Header("Bindings")]
		[SerializeField]
		private List<TextDataBinderBindingData> bindings;

		[SerializeField]
		private List<TextDataBinderBindingData> runtimeBindings;

		[SerializeField]
		private List<TextDataBinderBindingData> dynamicBindings;

		private static LocalizationManager LocalizationManager => null;

		private List<string> LocalizedStringTableNames => null;

		private List<string> LocalizedFontMaterialKeys => null;

		private bool IsStaticLocalizated => false;

		private bool IsDynamicLocalizated => false;

		public List<TextDataBinderBindingData> AllRuntimeBindings => null;

		public List<string> Text => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void RequestUpdate()
		{
		}

		private void SetLocalizedStringKey(string key)
		{
		}

		private string ParseAndSetCustomMaterialsInText(string text)
		{
			return null;
		}

		private void SetText(string text)
		{
		}

		private void SetFont(TMP_FontAsset font)
		{
		}

		private void SetTMPFont(TMP_Text tmp, TMP_FontAsset font)
		{
		}

		public void UpdateText()
		{
		}

		private void OnValueChangedString(string _)
		{
		}

		private void OnValueChangedInt(int _)
		{
		}

		private void OnValueChangedFloat(float _)
		{
		}

		private void OnValueChangedObject(object _)
		{
		}

		private void RegisterBindings()
		{
		}

		private void UnregisterBindings()
		{
		}

		public void AddDynamicBinding(TextDataBinderBindingData binding)
		{
		}

		public void AddDynamicBindings(IEnumerable<TextDataBinderBindingData> newBindings)
		{
		}

		public void RemoveDynamicBinding(TextDataBinderBindingData binding)
		{
		}

		public void RemoveDynamicBindings(IEnumerable<TextDataBinderBindingData> bindingsToRemove)
		{
		}

		public void ClearDynamicBindings()
		{
		}
	}
}
