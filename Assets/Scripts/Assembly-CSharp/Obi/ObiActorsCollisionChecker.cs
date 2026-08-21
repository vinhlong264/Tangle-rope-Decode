using UnityEngine;

namespace Obi
{
	public class ObiActorsCollisionChecker : MonoBehaviour
	{
		[SerializeField]
		private ObiSolver solver;

		[SerializeField]
		private ObiCollisionsChannel collisionsChannel;

		[SerializeField]
		private float updatePeriod;

		private float lastUpdateAllTime;

		private float lastUpdateContactsTime;

		private float lastSurfaceContactsTime;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnObiParticleCollision(ObiSolver obiSolver, ObiSolver.ObiCollisionEventArgs args)
		{
		}

		private void OnObiCollision(ObiSolver obiSolver, ObiSolver.ObiCollisionEventArgs contacts)
		{
		}
	}
}
