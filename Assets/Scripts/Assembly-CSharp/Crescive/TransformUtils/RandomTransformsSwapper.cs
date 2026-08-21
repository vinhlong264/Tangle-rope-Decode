using System.Collections.Generic;
using UnityEngine;

namespace Crescive.TransformUtils
{
	public class RandomTransformsSwapper : MonoBehaviour
	{
		private struct TransformData
		{
			public Vector3 position;

			public Quaternion rotation;

			public Vector3 localScale;

			public TransformData(Transform transform)
			{
				position = default(Vector3);
				rotation = default(Quaternion);
				localScale = default(Vector3);
			}
		}

		[SerializeField]
		private bool autoSwapOnAwake;

		[SerializeField]
		private List<Transform> transforms;

		private void Awake()
		{
		}

		public void SwapTransformsRandomly()
		{
		}

		private void ApplyTransformData(Transform tr, TransformData data)
		{
		}
	}
}
