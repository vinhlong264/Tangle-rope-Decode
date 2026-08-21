using System;
using UnityEngine;

namespace MG.GIF
{
	public class Image : ICloneable
	{
		public int Width;

		public int Height;

		public int Delay;

		public Color32[] RawImage;

		public Image()
		{
		}

		public Image(Image img)
		{
		}

		public object Clone()
		{
			return null;
		}

		public Texture2D CreateTexture()
		{
			return null;
		}
	}
}
