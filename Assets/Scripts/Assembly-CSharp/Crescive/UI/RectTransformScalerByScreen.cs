using UnityEngine;

namespace Crescive.UI
{
	public class RectTransformScalerByScreen : MonoBehaviour
	{
		[SerializeField]
		private RectTransform rectTransform;

		[SerializeField]
		private Vector2 referenceResolution;

		[SerializeField]
		private float minScale;

		private float referenceScreenRatio;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
