using Crescive.TwistedTangle;
using DG.Tweening;
using UnityEngine;

namespace Crescive.Collection.Preview
{
	public class RopePreviewAnimator : MonoBehaviour
	{
		[SerializeField]
		private RopeEntity ropeEntity;

		[SerializeField]
		private float punchThicknessPower;

		[SerializeField]
		private float punchThicknessDuration;

		[SerializeField]
		private int punchThicknessVibrato;

		[SerializeField]
		private Ease punchThicknessEase;

		public void OnCollectionItemChanged()
		{
		}
	}
}
