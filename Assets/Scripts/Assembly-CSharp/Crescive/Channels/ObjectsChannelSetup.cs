using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Channels
{
	[DefaultExecutionOrder(-101)]
	public class ObjectsChannelSetup<TChannel, TData> : MonoBehaviour where TChannel : ObjectsChannel<TData> where TData : Object
	{
		[SerializeField]
		private TChannel objectsChannel;

		[SerializeField]
		private bool autoSetupOnAwake;

		[SerializeField]
		private bool autoSetupOnStart;

		[SerializeField]
		private bool autoSetupOnEnable;

		[SerializeField]
		private bool autoFindInChildren;

		[SerializeField]
		private bool autoFindInScene;

		[SerializeField]
		private bool includeInactive;

		[SerializeField]
		private List<TData> data;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		public void Setup()
		{
		}
	}
}
