using Crescive.Navigation;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.LiveEvents.DynamicQuest
{
	[CreateAssetMenu(fileName = "Dynamic Quest Push Reward Claim For Golden Pass Claim Action", menuName = "Crescive/Monetization Features/Live Events/Dynamic Quest/Action/Dynamic Quest Push Reward Claim For Golden Pass Claim Action")]
	public class DynamicQuestPushRewardClaimForGoldenPassClaimAction : ScriptableObject
	{
		[SerializeField]
		private DynamicQuestSystem dynamicQuestSystem;

		[SerializeField]
		private NavigationChannel menuPopupChannel;

		[SerializeField]
		private StringConstant rewardClaimPopupId;

		[SerializeField]
		private StringConstant progressPopupId;

		public UnityEvent OnGoldenPassClaimed;

		private void OnClaimPopupHide()
		{
		}

		public void Invoke()
		{
		}
	}
}
