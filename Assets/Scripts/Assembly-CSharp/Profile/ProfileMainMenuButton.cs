using Crescive.LiveEvents.BattlePass;
using Crescive.Navigation;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Profile
{
	public class ProfileMainMenuButton : MonoBehaviour
	{
		[SerializeField]
		private NavigationChannel menuPopupNavigationChannel;

		[SerializeField]
		private StringConstant profileMainPanelId;

		[SerializeField]
		private ProfilePictureUI profilePictureUI;

		[SerializeField]
		private BattlePassSystem battlePassSystem;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnProfileDataChanged()
		{
		}

		private void OnClicked()
		{
		}
	}
}
