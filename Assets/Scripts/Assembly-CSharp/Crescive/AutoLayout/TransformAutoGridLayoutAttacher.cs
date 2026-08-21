using UnityEngine;

namespace Crescive.AutoLayout
{
	public class TransformAutoGridLayoutAttacher : MonoBehaviour
	{
		public enum GridDirection
		{
			TOP = 0,
			BOTTOM = 1,
			LEFT = 2,
			RIGHT = 3
		}

		[SerializeField]
		private Transform target;

		[SerializeField]
		private TransformAutoGridLayoutChannel gridLayoutChannel;

		[SerializeField]
		private GridDirection direction;

		[SerializeField]
		private Vector3 offset;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void UpdatePosition()
		{
		}
	}
}
