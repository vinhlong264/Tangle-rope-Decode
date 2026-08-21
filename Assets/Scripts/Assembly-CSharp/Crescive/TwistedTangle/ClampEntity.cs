using System.Collections.Generic;
using BrunoMikoski.AnimationSequencer;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class ClampEntity : MonoBehaviour
	{
		[SerializeField]
		private List<Collider> colliders;

		[SerializeField]
		private AnimationSequencerController unclampAnimSeq;

		private bool unlocked;

		public UnityEvent OnUnclamp;

		[field: SerializeField]
		public Transform LockEnterPivot { get; private set; }

		public void Unlock()
		{
		}

		public void SetCollidersActive(bool active)
		{
		}
	}
}
