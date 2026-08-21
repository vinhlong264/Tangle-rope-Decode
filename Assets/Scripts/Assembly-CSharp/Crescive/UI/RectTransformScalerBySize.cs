using UnityEngine;

namespace Crescive.UI
{
	public class RectTransformScalerBySize : MonoBehaviour
	{
		[SerializeField]
		private RectTransform rectTransform;

		[SerializeField]
		private Vector2 referenceSize;

		[SerializeField]
		private bool uniformScale;

		private Vector3 originalScale;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void SetReferenceSizeToCurrentSize()
		{
		}
	}
}
