using System.Collections.Generic;
using CresciveCore;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Plinko
{
	public class PlinkoHomeMenuButton : MonoBehaviour
	{
		[SerializeField]
		private Button button;

		[SerializeField]
		private GameObject main;

		[SerializeField]
		private LayoutElement layoutElement;

		[SerializeField]
		private LevelSystem levelSystem;

		private List<Image> animTokenImages;

		private Sequence tokenSequence;

		private Vector3 scalePivotInitialScale;

		[SerializeField]
		private Image animTokenImageDefault;

		[SerializeField]
		private Transform scalePivot;

		[SerializeField]
		private RectTransform tokenImage;

		private PlinkoEvents.OnPlinkoTokenEarned lastEarnedData;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnPlinkoTokenEarned(PlinkoEvents.OnPlinkoTokenEarned p)
		{
		}

		private void AnimateTokens(int totalEarnedCount)
		{
		}

		private void OnClicked()
		{
		}
	}
}
