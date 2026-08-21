using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class RWMoveCountProvider : MonoBehaviour
	{
		[SerializeField]
		private IntVariable rwMinMoveCount;

		[SerializeField]
		private IntVariable rwMaxMoveCount;

		[SerializeField]
		private IntVariable predictedRemainingMoveCount;

		[SerializeField]
		private bool triggerEventsOnAwake;

		[SerializeField]
		private bool triggerEventsOnEnable;

		[SerializeField]
		private bool triggerEventsOnStart;

		public UnityEvent<int> OnGetRWMoveCount;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		public void TriggerRWMoveCount()
		{
		}
	}
}
