using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Utils
{
	[DefaultExecutionOrder(-999999999)]
	public class PlatformListener : MonoBehaviour
	{
		[SerializeField]
		private List<RuntimePlatform> targetPlatforms;

		public UnityEvent OnMatchOnAwake;

		public UnityEvent OnNotMatchOnAwake;

		public UnityEvent<bool> OnCheckOnAwake;

		public UnityEvent OnMatchOnStart;

		public UnityEvent OnNotMatchOnStart;

		public UnityEvent<bool> OnCheckOnStart;

		public UnityEvent OnMatchOnEnable;

		public UnityEvent OnNotMatchOnEnable;

		public UnityEvent<bool> OnCheckOnEnable;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private bool CheckPlatform()
		{
			return false;
		}
	}
}
