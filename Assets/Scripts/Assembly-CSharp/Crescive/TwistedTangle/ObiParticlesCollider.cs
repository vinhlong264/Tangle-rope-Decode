using System.Collections.Generic;
using Obi;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class ObiParticlesCollider : MonoBehaviour
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

		private List<SphereCollider> sphereColliders;

		private void Awake()
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

		private void AddSphereColliders(int count)
		{
		}

		private void AddSphereCollider()
		{
		}
	}
}
