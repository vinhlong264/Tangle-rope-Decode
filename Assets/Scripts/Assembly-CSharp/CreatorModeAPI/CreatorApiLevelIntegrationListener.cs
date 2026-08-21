using Crescive.CreatorMode;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace CreatorModeAPI
{
	public class CreatorApiLevelIntegrationListener : MonoBehaviour
	{
		[SerializeField]
		private CreatorApiRequestLevelIntegration requester;

		public UnityEvent OnAnyRequestStarted;

		public UnityEvent OnAnyRequestFinished;

		public UnityEvent OnAnyRequestFailed;

		public UnityEvent<string> OnGetCreatorLevelByIdStarted;

		public UnityEvent<string> OnGetCreatorLevelByIdFinished;

		public UnityEvent<string> OnGetCreatorLevelByIdFailed;

		public UnityEvent OnAddCreatorLevelStarted;

		public UnityEvent<string> OnAddCreatorLevelFinished;

		public UnityEvent OnAddCreatorLevelFailed;

		public UnityEvent<UniTask> OnRequestAnyAsync;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
