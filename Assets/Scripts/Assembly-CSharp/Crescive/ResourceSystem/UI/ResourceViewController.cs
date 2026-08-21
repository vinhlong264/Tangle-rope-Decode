using DG.Tweening;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.ResourceSystem.UI
{
	[DefaultExecutionOrder(1)]
	[RequireComponent(typeof(ResourceAnimationTarget))]
	public class ResourceViewController : MonoBehaviour
	{
		[Header("Dependencies")]
		[SerializeField]
		private ResourceAnimationTarget resourceAnimationTarget;

		[SerializeField]
		private Transform coinDestination;

		[SerializeField]
		private Transform resourceModelParent;

		[Header("References")]
		[SerializeField]
		private ResourceChannel resourceChannel;

		[Header("Bindings")]
		[SerializeField]
		private FloatVariableInstancer resourceVar;

		[SerializeField]
		private bool smoothUpdateVar;

		[SerializeField]
		private bool useIntegers;

		[SerializeField]
		private float smoothUpdateTime;

		[SerializeField]
		private Ease smoothUpdateEase;

		private Tween smoothUpdateTween;

		public UnityEvent OnIncreaseCompleted;

		public UnityEvent OnDecreaseCompleted;

		public UnityEvent<bool> OnIsInfinite;

		public UnityEvent<bool> OnIsNotInfinite;

		public ResourceAnimationTarget AnimationTarget => null;

		public bool IsInfinite => false;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void UpdateUI()
		{
		}

		private void UpdateResourceVar()
		{
		}

		private void OnResourceChanged(float value)
		{
		}

		private void OnIsInfiniteChanged(bool value)
		{
		}

		private void SubscribeToResourceChannelAndInitializeVariables()
		{
		}

		private void UnsubscribeFromResourceChannel()
		{
		}

		public void SetResourceChannel(ResourceChannel channel)
		{
		}
	}
}
