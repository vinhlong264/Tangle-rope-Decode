using DG.Tweening;
using UnityEngine;

namespace Crescive.TransformUtils
{
	public class TransformScaler : MonoBehaviour
	{
		[SerializeField]
		private Transform pivot;

		[SerializeField]
		private float smoothDuration;

		[SerializeField]
		private Ease smoothEase;

		[SerializeField]
		private bool useUnscaledTime;

		[SerializeField]
		private bool updateX;

		[SerializeField]
		private bool updateY;

		[SerializeField]
		private bool updateZ;

		private Tween scaleTween;

		public void Scale(float scale)
		{
		}

		public void Scale(Vector3 scale)
		{
		}

		public void ScaleSmooth(float scale)
		{
		}

		public void ScaleSmooth(Vector3 scale)
		{
		}

		private Vector3 GetScaleVector(float scale)
		{
			return default(Vector3);
		}
	}
}
