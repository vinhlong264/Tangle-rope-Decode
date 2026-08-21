using System;
using UnityEngine;
using UnityEngine.UI;

namespace Profile
{
	public class ProfilePictureUI : MonoBehaviour
	{
		[SerializeField]
		private Image profileImage;

		[SerializeField]
		private Image frameImage;

		[SerializeField]
		private Image goldenFrameImage;

		[SerializeField]
		private Image lockImage;

		[SerializeField]
		private Button interactionButton;

		[SerializeField]
		private Image selectedOutline;

		[SerializeField]
		internal Sprite[] profilePictures;

		[SerializeField]
		internal Color[] profileColors;

		internal void SetData(int profilePictureIndex, int profileFrameIndex, bool isLocked = false, Action onClick = null, Action onLockClicked = null)
		{
		}

		public void SetSelectedOutline(bool selected)
		{
		}
	}
}
