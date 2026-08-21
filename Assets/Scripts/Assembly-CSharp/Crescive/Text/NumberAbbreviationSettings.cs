using System;
using UnityEngine;

namespace Crescive.Text
{
	[Serializable]
	public struct NumberAbbreviationSettings
	{
		[SerializeField]
		private bool use;

		[SerializeField]
		private int abbreviationThreshold;

		[SerializeField]
		private bool useCustomFormat;

		[SerializeField]
		private string format;

		private bool ShowItem => false;

		private bool ShowFormat => false;

		public bool TryApply(float number, out string abbreviatedNumber)
		{
			abbreviatedNumber = null;
			return false;
		}
	}
}
