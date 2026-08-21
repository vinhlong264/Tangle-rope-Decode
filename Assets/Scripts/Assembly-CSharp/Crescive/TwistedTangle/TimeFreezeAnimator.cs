using System;
using System.Collections.Generic;
using Crescive.HelperTypes;
using Crescive.TransformUtils;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class TimeFreezeAnimator : MonoBehaviour
	{
		[SerializeField]
		private TimeFreezeAnimatorChannel timeFreezeAnimatorChannel;

		[SerializeField]
		private FloatVariableReference timeFreezeDuration;

		[SerializeField]
		private List<CanvasGroup> fadeCanvasGroups;

		[SerializeField]
		private ParticleSystem frostMissile;

		[SerializeField]
		private ParticleSystem frostExplosion;

		[SerializeField]
		private List<BoolVariableReference> disableUpdateConditions;

		[Space]
		[SerializeField]
		private Transform missileStartPoint;

		[SerializeField]
		private TransformChannel missileEndPoint;

		[SerializeField]
		[Space]
		private bool autoCallDeactivate;

		[SerializeField]
		private List<TimeFreezeFadeFx> fadeFxList;

		[SerializeField]
		private List<TimeFreezeCountdownBar> countdownBarList;

		private List<Tween> countdownTweens;

		public UnityEvent OnFreezeTime;

		public List<TimeFreezeFadeFx> FadeFxList => null;

		public List<TimeFreezeCountdownBar> CountdownBarList => null;

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void InitializeAnimation()
		{
		}

		private void MissileShootAnimation()
		{
		}

		private void ActivateFrame()
		{
		}

		private void DeactivateFrame(bool immediate)
		{
		}

		private void ActivateFadeCanvasGroup(CanvasGroup canvasGroup, Action onActivate)
		{
		}

		private void DeactivateFadeCanvasGroup(CanvasGroup canvasGroup, Action onDeactivate, bool immediate, bool deactivateObject)
		{
		}

		private void StartCountdownBar(TimeFreezeCountdownBar countdownBar)
		{
		}

		private void StopParticles()
		{
		}

		private void ClearParticles()
		{
		}

		public void PlayAnimation()
		{
		}

		public void CancelAnimation()
		{
		}
	}
}
