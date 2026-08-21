using System;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	[CreateAssetMenu(fileName = "Texture Holder", menuName = "Special Editor/Texture Holder")]
	public class TextureHolder : ScriptableObject
	{
		[SerializeField]
		private Texture2D texture;

		public Action<Texture2D> OnTextureChanged;

		public Texture2D Texture => null;

		public void SetTexture(Texture2D texture)
		{
		}
	}
}
