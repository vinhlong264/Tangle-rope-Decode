using System;
using UnityEngine;

namespace Crescive.Text
{
	[Serializable]
	public struct TextDataBindingStylingData
	{
		public bool Bold;

		public bool Italic;

		public bool UpperCase;

		public bool HasSizePercent;

		public float SizePercent;

		public bool HasColor;

		public Color Color;

		public bool SpaceBefore;

		public bool SpaceAfter;

		public bool EndLine;

		public void ApplyStyling(ref string text)
		{
		}

		private void ApplySizePercent(ref string text)
		{
		}

		private void ApplyBold(ref string text)
		{
		}

		private void ApplyItalic(ref string text)
		{
		}

		private void ApplyColor(ref string text)
		{
		}

		private void ApplySpacing(ref string text)
		{
		}

		private void ApplyUpperCase(ref string text)
		{
		}
	}
}
