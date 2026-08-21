using CresciveCore;
using UnityEngine;

namespace Systems.EventHelpers
{
	public class SameSlotPinRopeMerged : MonoBehaviour
	{
		[SerializeField]
		private LevelSystem levelSystem;

		private bool isSameSlot;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnRopesMerged()
		{
		}

		private void OnRopeDrop(GameEvents.OnRopeDrop p)
		{
		}
	}
}
