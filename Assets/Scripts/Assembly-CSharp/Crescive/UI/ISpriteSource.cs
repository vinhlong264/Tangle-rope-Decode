using UnityEngine;

namespace Crescive.UI
{
	public interface ISpriteSource
	{
		Sprite Sprite { get; }

		Sprite SpriteL { get; }

		Sprite SpriteXL { get; }
	}
}
