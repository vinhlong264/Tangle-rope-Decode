using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	public class RopeCollider : MonoBehaviour
	{
		[SerializeField]
		private ObiActor obiActor;

		[SerializeField]
		private int initialPoolCapacity;

		[SerializeField]
		private bool useNormalUpdate;

		[SerializeField]
		private bool isTrigger;

		[SerializeField]
		private float radiusMultiplier;

		[SerializeField]
		private bool hideColliderComponents;

		[SerializeField]
		private float colliderHeight;

		[SerializeField]
		private float updatePeriod;

		private List<BoxCollider> colliders;

		private float timer;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Setup()
		{
		}

		private void UpdateColliders()
		{
		}

		private void UpdateColliderComponentsVisibility()
		{
		}

		private void GrowPoolIfNeeded(int particleCount)
		{
		}

		private void AddColliders(int count)
		{
		}

		private void AddCollider()
		{
		}

		private void SetCollidersActive(bool active)
		{
		}
	}
}
