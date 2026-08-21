using UnityEngine;
using UnityEngine.Events;

namespace Crescive.ResourceSystem.UI
{
	[DefaultExecutionOrder(1)]
	public class ResourceAnimationTarget : MonoBehaviour
	{
		[SerializeField]
		[Header("Dependencies")]
		private ResourceAnimationTargetsChannel targetsChannel;

		[SerializeField]
		private Transform coinDestination;

		[SerializeField]
		private Transform resourceModelParent;

		[SerializeField]
		[Header("References")]
		private ResourceChannel resourceChannel;

		[SerializeField]
		private ResourceAnimation resourceAnimation;

		[Header("Settings")]
		[SerializeField]
		private int priority;

		[SerializeField]
		private bool animateImageOnChanged;

		private Camera mainCam;

		public UnityEvent OnIncreaseCompleted;

		public UnityEvent OnDecreaseCompleted;

		public ResourceChannel ResourceChannel => null;

		public string ResourceTypeId => null;

		public int Priority => 0;

		private Camera MainCam => null;

		private bool IsCurrentTarget => false;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void TriggerResourceImageAnimation(float _)
		{
		}

		private void TriggerIncreaseAnimation(ResourceValueEventArgs args)
		{
		}

		private void TriggerDecreaseAnimation(ResourceValueEventArgs args)
		{
		}

		private void SubscribeToResourceChannelAndSetup()
		{
		}

		private void UnsubscribeFromResourceChannelAndReset()
		{
		}

		public void SetResourceChannel(ResourceChannel channel)
		{
		}

		public void SetResourceAnimation(ResourceAnimation animation)
		{
		}

		public void SetResourceModelParent(Transform modelParent)
		{
		}
	}
}
