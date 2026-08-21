using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Systems
{
	public class SettingsThemeAB : MonoBehaviour
	{
		[SerializeField]
		private GameObject retryButton;

		[SerializeField]
		private GridLayoutGroup gridLayoutGroup;

		[SerializeField]
		private AtomConditionListener atomConditionListener;

		[SerializeField]
		private SettingsThemeContentSetter settingsThemeContentSetter;

		[SerializeField]
		private StringVariable levelType;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnReturnedHome()
		{
		}

		private void OnLevelCreated()
		{
		}

		public void CheckRetryButtonActivationAndContentCorrection(bool isActive)
		{
		}

		public void SetContent(bool isActive)
		{
		}
	}
}
