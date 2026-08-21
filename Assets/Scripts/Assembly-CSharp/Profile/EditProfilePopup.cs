using Crescive.LiveEvents.BattlePass;
using Crescive.Navigation;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Profile
{
	public class EditProfilePopup : MonoBehaviour
	{
		[SerializeField]
		private ProfilePictureUI mainProfilePicture;

		[SerializeField]
		private ProfilePictureUI[] profilePictureUIs;

		[SerializeField]
		private TMP_InputField nameInputField;

		[SerializeField]
		private Button closeButton;

		[SerializeField]
		private Button saveButton;

		[SerializeField]
		private Button profilePictureTabButton;

		[SerializeField]
		private Button frameTabButton;

		[SerializeField]
		private Sprite profileFocusedSprite;

		[SerializeField]
		private Sprite profileUnfocusSprite;

		[SerializeField]
		private Sprite frameFocusedSprite;

		[SerializeField]
		private Sprite frameUnfocusedSprite;

		[SerializeField]
		private Navigatable navigatable;

		[SerializeField]
		private BattlePassSystem battlePassSystem;

		[SerializeField]
		private RectTransform tooltip;

		[SerializeField]
		private Button tooltipCloseButton;

		[SerializeField]
		private GameObject saveChangesMain;

		[SerializeField]
		private Button saveChangesButton;

		[SerializeField]
		private Button discardChangesButton;

		private ProfileData profileData;

		private bool isChanged;

		private bool isOnPictureTab;

		private void Awake()
		{
		}

		private void OnTooltipCloseButtonClicked()
		{
		}

		private void OnSaveChangesSaveButtonClicked()
		{
		}

		private void OnSaveChangesDiscardButtonClicked()
		{
		}

		private void OnSaveButtonClicked()
		{
		}

		private void OnProfileTabClicked()
		{
		}

		private void OnFrameTabClicked()
		{
		}

		private void OnCloseButtonClicked()
		{
		}

		private void OpenSaveChanges()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnShow()
		{
		}

		public void SetProfilePictureTab()
		{
		}

		public void SetFrameTab()
		{
		}

		private void OnLockedItemClicked(int index)
		{
		}

		private void OnProfilePictureSelected(int index)
		{
		}

		private void OnProfileFrameSelected(int index)
		{
		}

		private void OnNameInputValueChanged(string name)
		{
		}
	}
}
