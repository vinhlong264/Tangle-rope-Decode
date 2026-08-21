using TMPro;
using UnityEngine;

namespace FigmaImporter.Extras
{
	[RequireComponent(typeof(TextMeshProUGUI))]
	[ExecuteAlways]
	public class TmpTextView : TextView
	{
		[SerializeField]
		private TextMeshProUGUI m_TmpText;

		public TMP_Text TmpText => null;

		protected void OnEnable()
		{
		}

		public override void SetText(string value)
		{
		}

		public override void SetColor(Color value)
		{
		}
	}
}
