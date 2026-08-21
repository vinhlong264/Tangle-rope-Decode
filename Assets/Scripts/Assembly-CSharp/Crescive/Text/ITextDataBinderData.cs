using UnityAtoms.BaseAtoms;

namespace Crescive.Text
{
	public interface ITextDataBinderData
	{
		TextDataBinderBindingType DataType { get; }

		string PlainText { get; }

		StringVariable AtomString { get; }

		IntVariable AtomInt { get; }

		FloatVariable AtomFloat { get; }

		StringVariableInstancer AtomStringInstancer { get; }

		IntVariableInstancer AtomIntInstancer { get; }

		FloatVariableInstancer AtomFloatInstancer { get; }

		bool UseRoundedValue { get; }

		bool UseAbbreviatedValue { get; }

		bool UsePositiveSign { get; }

		string FloatFormat { get; }

		string Data { get; }
	}
}
