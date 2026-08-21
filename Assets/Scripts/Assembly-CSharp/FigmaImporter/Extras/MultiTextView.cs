using UnityEngine;

namespace FigmaImporter.Extras
{
	public class MultiTextView : TextView
	{
		[SerializeField]
		private TextView[] m_textViewList;

		private void Reset()
		{
		}

		public override void SetText(string text)
		{
		}

		public override void SetColor(Color value)
		{
		}
	}
}
