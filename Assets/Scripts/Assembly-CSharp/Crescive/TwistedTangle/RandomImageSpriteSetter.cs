using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.TwistedTangle
{
	public class RandomImageSpriteSetter : MonoBehaviour
	{
		[SerializeField]
		private Image image;

		[SerializeField]
		private List<Sprite> sprites;

		private void OnEnable()
		{
		}
	}
}
