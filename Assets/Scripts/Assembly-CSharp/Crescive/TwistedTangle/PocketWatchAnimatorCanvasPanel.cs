using Crescive.TransformUtils;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class PocketWatchAnimatorCanvasPanel : MonoBehaviour
	{
		[SerializeField]
		private TransformChannel timeTextTransform;

		[SerializeField]
		private RectTransform timeTextAnimatePivot;

		public RectTransform TimeTextAnimatePivot => null;

		public RectTransform TimeTextTransform => null;
	}
}
