using Crescive.Navigation;
using PersistentSO;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Profile
{
	public class ProfilePopup : MonoBehaviour
	{
		public static ProfilePopup Instance;

		[SerializeField]
		private ProfilePictureUI mainProfilePicture;

		[SerializeField]
		private TextMeshProUGUI nameText;

		[SerializeField]
		private TextMeshProUGUI levelText;

		[SerializeField]
		private TextMeshProUGUI playingSinceText;

		[SerializeField]
		private Button closeButton;

		[SerializeField]
		private Button editButton;

		[SerializeField]
		private Navigatable navigatable;

		[SerializeField]
		private StringConstant profileEditPopupID;

		[SerializeField]
		private NavigationChannel menuPopupNavigationChannel;

		[SerializeField]
		private TextMeshProUGUI firstTryWinStatText;

		[SerializeField]
		private TextMeshProUGUI consecutiveDailyLoginStatText;

		[SerializeField]
		private TextMeshProUGUI maxLevelPerDayStatText;

		[SerializeField]
		private TextMeshProUGUI WinRateStatText;

		[SerializeField]
		private Button playingSinceInfoButton;

		[SerializeField]
		private Button playingSinceCloseButton;

		[SerializeField]
		private GameObject playingSinceInfoMain;

		[SerializeField]
		private TextMeshProUGUI playingSinceInfoText;

		[SerializeField]
		public PersistentIntVariable currentLevelNumber;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnLevelNumberChanged(GameEvents.OnLevelNumberChanged p)
		{
		}

		private void OnLevelChanged(int newLevelNumber)
		{
		}

		private void OnPlayingSinceInfoButtonClicked()
		{
		}

		private void OnPlayingSinceCloseButtonClicked()
		{
		}

		private void OnProfileDataChanged()
		{
		}

		private void OnEditButtonClicked()
		{
		}

		private void OnCloseButtonClicked()
		{
		}

		public void SetProfileData(ProfileData profileData, bool isEditable = false)
		{
		}
	}
}
