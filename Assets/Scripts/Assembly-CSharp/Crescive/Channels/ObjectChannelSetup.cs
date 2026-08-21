using UnityEngine;

namespace Crescive.Channels
{
	[DefaultExecutionOrder(int.MinValue)]
	public abstract class ObjectChannelSetup<TChannel, TData> : MonoBehaviour where TChannel : ObjectChannel<TData> where TData : Object
	{
		[SerializeField]
		private TChannel objectChannel;

		[SerializeField]
		private TData data;

		[SerializeField]
		private bool autoSetupOnAwake;

		[SerializeField]
		private bool autoSetupOnStart;

		[SerializeField]
		private bool autoSetupOnEnable;

		[SerializeField]
		private bool autoResetOnDisable;

		[SerializeField]
		private bool autoResetOnDestroy;

		[SerializeField]
		private bool autoFindInChildren;

		[SerializeField]
		private bool autoFindInScene;

		[SerializeField]
		private bool includeInactive;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void Setup()
		{
		}
	}
}
