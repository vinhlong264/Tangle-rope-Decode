using UnityEngine;

namespace Crescive.Channels
{
	public class ChannelObject<TChannel, TData> : MonoBehaviour where TChannel : ObjectsChannel<TData> where TData : Object
	{
		[SerializeField]
		private TChannel channel;

		[SerializeField]
		private TData data;

		[SerializeField]
		private bool autoAddOnEnable;

		[SerializeField]
		private bool autoAddOnAwake;

		[SerializeField]
		private bool autoAddOnStart;

		[SerializeField]
		private bool autoRemoveOnDisable;

		[SerializeField]
		private bool autoRemoveOnDestroy;

		private void OnEnable()
		{
		}

		private void Awake()
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
	}
}
