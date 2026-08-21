using UnityEngine;

namespace FigmaImporter.Extras
{
	public abstract class TextView : MonoBehaviour
	{
		public abstract void SetText(string text);

		public abstract void SetColor(Color value);
	}
}
