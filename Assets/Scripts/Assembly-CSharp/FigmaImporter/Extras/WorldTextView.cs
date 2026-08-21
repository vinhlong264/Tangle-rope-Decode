using TMPro;
using UnityEngine;

namespace FigmaImporter.Extras
{
	[ExecuteAlways]
	[RequireComponent(typeof(TextMeshPro))]
	public class WorldTextView : TextView
	{
		[SerializeField]
		private TextMeshPro m_TmpText;

		private void OnEnable()
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
