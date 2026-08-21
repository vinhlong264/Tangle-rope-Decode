using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class TextureImporter : MonoBehaviour
	{
		[SerializeField]
		private UnityEvent<Texture2D> OnTextureLoaded;

		public void LoadTexture(string path)
		{
		}

		public void LoadFile()
		{
		}
	}
}
