using System;
using UnityAtoms.BaseAtoms;

namespace Crescive.Atom
{
	[Serializable]
	public class StringVariableTypeField : AtomVariableTypeField<StringVariable, StringVariableInstancer, string, StringPair, StringEvent, StringPairEvent, StringStringFunction>
	{
	}
}
