using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Crescive.Leveling
{
	public class LevelingButton : MonoBehaviour
	{
		[SerializeField]
		[Header("Static Info")]
		private Image iconImage;

		[SerializeField]
		private Image backgroundImage;

		[SerializeField]
		private TMP_Text titleTmp;

		[Header("Dynamic Info")]
		[SerializeField]
		private TMP_Text levelTmp;

		[SerializeField]
		private TMP_Text costTmp;

		[SerializeField]
		private IntVariableInstancer costVariable;

		[Header("Events")]
		[SerializeField]
		private UnityEvent onMaxLevelReached;

		[SerializeField]
		[Header("State")]
		private LevelingButtonData levelingButtonData;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void UpdateDynamicInfo()
		{
		}

		private void RegisterToLeveling()
		{
		}

		private void UnregisterFromLeveling()
		{
		}

		private void OnLevelChanged(int level)
		{
		}

		public void SetData(LevelingButtonData data)
		{
		}

		public void IncreaseLevel()
		{
		}
	}
}
