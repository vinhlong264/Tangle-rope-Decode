using UnityEngine.Events;

namespace UnityEngine.MonoUtils
{
	public class GameObjectEventsListener : MonoBehaviour
	{
		[SerializeField]
		private bool dontCallAwakeIfNotEnabled;

		public UnityEvent OnAwake;

		public UnityEvent OnStart;

		public UnityEvent OnEnabled;

		public UnityEvent OnDisabled;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
