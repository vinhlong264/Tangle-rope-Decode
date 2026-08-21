using Obi;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class ObiParticleAttacher : MonoBehaviour
	{
		[SerializeField]
		private ObiActor actor;

		[Range(0f, 1f)]
		[SerializeField]
		private float attachPercent;

		[SerializeField]
		private bool useNormalUpdate;

		public ObiActor Actor => null;

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private void UpdateSelf()
		{
		}

		public void AttachTo(ObiActor actor)
		{
		}

		public void Detach()
		{
		}

		public void SetAttachPercent(float percent)
		{
		}
	}
}
