using System;
using Crescive.HelperTypes;
using Crescive.Text;
using UnityEngine;

namespace Crescive.InfoTextPopUp
{
	[Serializable]
	public struct InfoTextPopUpArgs
	{
		public StringVariableReference message;

		public float stayDuration;

		public Transform positionPivot;

		public TextDataBinderBindingData[] bindings;
	}
}
