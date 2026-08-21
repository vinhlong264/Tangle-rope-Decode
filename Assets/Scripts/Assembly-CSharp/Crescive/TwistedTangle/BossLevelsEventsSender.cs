using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class BossLevelsEventsSender : MonoBehaviour
	{
		[SerializeField]
		private CresciveEventSender eventSender;

		[SerializeField]
		private string bossLevelTypeName;

		[SerializeField]
		private PersistentIntVariable currentBossLevelNumber;

		[SerializeField]
		private IntVariable totalMoveCount;

		[SerializeField]
		private IntVariable playTime;

		private int CurrentBossLevelNumber => 0;

		private string LevelTypeNumberPrefix => null;

		private void SendMoveCountEvent()
		{
		}

		private void SendPlayTimeEvent()
		{
		}

		public void OnBossLevelOffered()
		{
		}

		public void OnBossLevelOfferApproved()
		{
		}

		public void OnBossLevelStarted()
		{
		}

		public void OnBossLevelWin()
		{
		}

		public void OnBossLevelFail()
		{
		}

		public void OnBossLevelSkipped()
		{
		}

		public void SetBossLevelTypeName(string name)
		{
		}
	}
}
