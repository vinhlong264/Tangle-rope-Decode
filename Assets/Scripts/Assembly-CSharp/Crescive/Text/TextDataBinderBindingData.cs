using System;
using Crescive.Localization;
using Crescive.Scriptables;
using PersistentSO;
using UnityAtoms.BaseAtoms;

namespace Crescive.Text
{
	[Serializable]
	public struct TextDataBinderBindingData : ITextDataBinderData
	{
		public TextDataBinderBindingType dataType;

		public string plainText;

		public StringVariable atomString;

		public IntVariable atomInt;

		public FloatVariable atomFloat;

		public StringVariableInstancer atomStringInstancer;

		public IntVariableInstancer atomIntInstancer;

		public FloatVariableInstancer atomFloatInstancer;

		public PersistentStringVariable persistentString;

		public PersistentIntVariable persistentInt;

		public PersistentFloatVariable persistentFloat;

		public StringScriptableProperty stringScriptableProperty;

		public IntScriptableProperty intScriptableProperty;

		public FloatScriptableProperty floatScriptableProperty;

		public BasePersistentVariable basePersistent;

		public BaseScriptableProperty baseScriptableProperty;

		public LocalizedStringReference localizedStringReference;

		public TextDataBindingStylingData stylingData;

		public bool useRoundedValue;

		public bool useAbbreviatedValue;

		public bool usePositiveSign;

		public bool convertToTimeSpanMinutes;

		public string floatFormat;

		public bool useMaxValueText;

		public int maxValue;

		public string maxValueText;

		public bool useRankingFormat;

		public float numberOffset;

		public bool useTextFormatter;

		public BaseTextFormatter textFormatter;

		public TextDataBinderBindingType DataType => default(TextDataBinderBindingType);

		public string PlainText => null;

		public StringVariable AtomString => null;

		public IntVariable AtomInt => null;

		public FloatVariable AtomFloat => null;

		public StringVariableInstancer AtomStringInstancer => null;

		public IntVariableInstancer AtomIntInstancer => null;

		public FloatVariableInstancer AtomFloatInstancer => null;

		public PersistentStringVariable PersistentString => null;

		public PersistentIntVariable PersistentInt => null;

		public PersistentFloatVariable PersistentFloat => null;

		public StringScriptableProperty StringScriptableProperty => null;

		public IntScriptableProperty IntScriptableProperty => null;

		public FloatScriptableProperty FloatScriptableProperty => null;

		public BasePersistentVariable BasePersistent => null;

		public BaseScriptableProperty BaseScriptableProperty => null;

		public LocalizedStringReference LocalizedStringReference => null;

		public bool UseRoundedValue => false;

		public bool UseAbbreviatedValue => false;

		public bool UsePositiveSign => false;

		public bool ConvertToTimeSpanMinutes => false;

		public string FloatFormat => null;

		public bool UseMaxValueText => false;

		public bool UseRankingFormat => false;

		public string Data => null;

		private bool ShowPlainText => false;

		private bool ShowAtomString => false;

		private bool ShowAtomInt => false;

		private bool ShowAtomFloat => false;

		private bool ShowAtomStringInstancer => false;

		private bool ShowAtomIntInstancer => false;

		private bool ShowAtomFloatInstancer => false;

		private bool ShowPersistentString => false;

		private bool ShowPersistentInt => false;

		private bool ShowPersistentFloat => false;

		private bool ShowStringScriptableProperty => false;

		private bool ShowIntScriptableProperty => false;

		private bool ShowFloatScriptableProperty => false;

		private bool ShowBasePersistent => false;

		private bool ShowBaseScriptableProperty => false;

		private bool ShowLocalizedStringReference => false;

		private bool IsManualFormatting => false;

		private bool IsInt => false;

		private bool IsFloat => false;

		private bool IsNumber => false;

		private bool ShouldShowUseRoundedValue => false;

		private bool ShouldShowUseAbbreviatedValue => false;

		private bool ShouldShowUsePositiveSign => false;

		private bool ShouldShowConvertToTimeSpan => false;

		private bool ShouldShowFloatFormat => false;

		private bool ShouldShowUseMaxValueText => false;

		private bool ShouldShowUseMaxValueTextElements => false;

		private bool ShouldShowUseRankingFormat => false;

		private bool ShouldShowNumberOffset => false;

		private string GetIntFormat(int value)
		{
			return null;
		}

		private string GetFloatFormat(float value)
		{
			return null;
		}

		private string GetObjectFormat(object value)
		{
			return null;
		}
	}
}
