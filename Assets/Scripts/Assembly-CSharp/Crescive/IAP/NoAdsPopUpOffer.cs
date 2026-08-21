using CresciveCore;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.IAP
{
	public class NoAdsPopUpOffer : MonoBehaviour
	{
		[SerializeField]
		private GameObject panel;

		[SerializeField]
		private PersistentBoolVariable firstInterDisplayed;

		[SerializeField]
		private PersistentBoolVariable offered;

		[SerializeField]
		private IntVariable minLevel;

		[SerializeField]
		private LevelSystem levelSystem;

		private void Start()
		{
		}
	}
}
