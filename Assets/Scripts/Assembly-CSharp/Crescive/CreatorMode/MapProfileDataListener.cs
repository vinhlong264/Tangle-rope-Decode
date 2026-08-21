using UnityEngine;
using UnityEngine.Events;

namespace Crescive.CreatorMode
{
	public class MapProfileDataListener : MonoBehaviour
	{
		[SerializeField]
		private MapProfileData mapProfileData;

		[SerializeField]
		private bool triggerOnAwake;

		[SerializeField]
		private bool triggerOnEnable;

		[SerializeField]
		private bool triggerOnStart;

		[SerializeField]
		private bool dontListenChanges;

		public UnityEvent<int> OnMapNumberChanged;

		public UnityEvent OnMapNumberMinReached;

		public UnityEvent OnMapNumberGreaterThanMin;

		public UnityEvent OnMapNumberMaxReached;

		public UnityEvent OnMapNumberLessThanMax;

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

		private void TriggerMapSizeNumberEvents(int number)
		{
		}
	}
}
