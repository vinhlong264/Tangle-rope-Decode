using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Ads
{
	public class CresciveRewardedAdRequesterListener : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private CresciveRewardedAdRequester requester;

		[SerializeField]
		private UnityEvent OnFailed;

		[SerializeField]
		private UnityEvent OnSkipped;

		[SerializeField]
		private UnityEvent OnFinished;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
