using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class StageLevelProgressBarUIController : MonoBehaviour
	{
		[SerializeField]
		private BoolReference isStagedLevel;

		[SerializeField]
		private IntReference currentStageIndex;

		[SerializeField]
		private BoolReference isTimeFrozen;

		[SerializeField]
		private StringReference currentLevelDifficulty;

		[SerializeField]
		private StringReference hardLevelDifficulty;

		[SerializeField]
		private StringReference veryHardLevelDifficulty;

		[SerializeField]
		private GameObject setActiveParent;

		[SerializeField]
		private List<GameObject> stageIndicators;

		[SerializeField]
		private List<Image> stageIndicatorImages;

		[SerializeField]
		private Sprite stageIndicatorSpriteNormal;

		[SerializeField]
		private Sprite stageIndicatorSpriteHard;

		[SerializeField]
		private Sprite stageIndicatorSpriteVeryHard;

		private int? _lastStageIndex;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDifficultyChanged(string _)
		{
		}

		private void OnIsStagedLevelChanged(bool _)
		{
		}

		private void OnStageLevelIndexChanged(int _)
		{
		}

		private void OnTimeFrozenChanged(bool _)
		{
		}

		private void CurrentStageAnimation()
		{
		}

		public void Refresh()
		{
		}

		private void RefreshDifficultyColors()
		{
		}

		private void RefreshStageCount()
		{
		}
	}
}
