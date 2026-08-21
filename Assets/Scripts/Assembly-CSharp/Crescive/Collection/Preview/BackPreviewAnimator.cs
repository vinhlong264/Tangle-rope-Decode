using DG.Tweening;
using UnityEngine;

namespace Crescive.Collection.Preview
{
	public class BackPreviewAnimator : MonoBehaviour
	{
		[SerializeField]
		private Transform punchTransform;

		[SerializeField]
		private float punchPower;

		[SerializeField]
		private float punchDuration;

		[SerializeField]
		private int punchVibrato;

		[SerializeField]
		private Ease punchEase;

		public void OnCollectionItemChanged()
		{
		}
	}
}
