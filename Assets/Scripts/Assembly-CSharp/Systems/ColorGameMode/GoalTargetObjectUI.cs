using System;
using TMPro;
using UnityEngine;

namespace Systems.ColorGameMode
{
	public class GoalTargetObjectUI : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI remainingCountText;

		[SerializeField]
		private GameObject tickIcon;

		public int targetCount { get; private set; }

		public int targetCountText { get; private set; }

		public int lastSetCount { get; private set; }

		internal void SetData(int targetCount)
		{
		}

		public void AnimateDecreaseTarget(Action onComplete = null)
		{
		}

		internal void DecreaseTarget()
		{
		}

		public void DecreaseTargetText()
		{
		}

		internal bool IsTargetDone()
		{
			return false;
		}
	}
}
