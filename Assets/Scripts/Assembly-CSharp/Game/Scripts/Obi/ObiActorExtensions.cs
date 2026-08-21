using System.Collections.Generic;
using Obi;
using UnityEngine;

namespace Game.Scripts.Obi
{
	public static class ObiActorExtensions
	{
		public static Vector3 GetParticlePositionAt(this ObiActor actor, int particleIndex)
		{
			return default(Vector3);
		}

		public static Vector3 GetParticlePositionAtPercent(this ObiActor actor, float percent)
		{
			return default(Vector3);
		}

		public static void SetParticlePositionAt(this ObiActor actor, int particleIndex, Vector3 position)
		{
		}

		public static void SetParticleRenderablePositionAt(this ObiActor actor, int particleIndex, Vector3 position)
		{
		}

		public static void SetParticleRenderablePositionAtPercent(this ObiActor actor, float percent, Vector3 position)
		{
		}

		public static void SetParticlePositionAtPercent(this ObiActor actor, float percent, Vector3 position)
		{
		}

		public static List<Vector3> GetParticlePositions(this ObiRope rope, bool useActiveParticles = false)
		{
			return null;
		}

		public static void SetParticlePositions(this ObiRope rope, List<Vector3> positions)
		{
		}

		public static void SetParticleRenderablePositions(this ObiRope rope, List<Vector3> positions)
		{
		}

		public static Quaternion GetParticleOrientationAt(this ObiActor actor, int particleIndex)
		{
			return default(Quaternion);
		}

		public static Quaternion GetParticleOrientationAtPercent(this ObiActor actor, float percent)
		{
			return default(Quaternion);
		}

		public static void SetParticleOrientationAt(this ObiActor actor, int particleIndex, Quaternion orientation)
		{
		}

		public static void SetParticleOrientationAtPercent(this ObiActor actor, float percent, Quaternion orientation)
		{
		}

		public static float GetParticleRadiusAt(this ObiActor actor, int particleIndex)
		{
			return 0f;
		}

		public static int GetParticleIndexAtPercent(this ObiActor actor, float percent)
		{
			return 0;
		}

		public static int GetParticleSolverIndexAtPercent(this ObiActor actor, float percent)
		{
			return 0;
		}

		public static List<int> GetParticleSolverIndexesAtPercentInverval(this ObiActor actor, float startPercent, float endPercent)
		{
			return null;
		}

		public static List<int> GetParticleSolverIndexes(this ObiActor actor)
		{
			return null;
		}

		public static List<int> GetParticlesFilters(this ObiActor actor, List<int> solverIndexes)
		{
			return null;
		}

		public static List<int> GetParticlesFilters(this ObiActor actor)
		{
			return null;
		}

		public static void SetParticlesFilters(this ObiActor actor, List<int> solverIndexes, int mask)
		{
		}

		public static void SetParticlesFilters(this ObiActor actor, List<int> filters)
		{
		}

		public static void SetParticlesFiltersToCollideWithEverything(this ObiActor actor, List<int> solverIndexes)
		{
		}

		public static void SetParticlesFiltersToCollideWithEverything(this ObiActor actor)
		{
		}

		public static void SetParticlesFiltersToCollideWithNothing(this ObiActor actor, List<int> solverIndexes)
		{
		}

		public static void SetParticlesFiltersToCollideWithNothing(this ObiActor actor)
		{
		}

		public static Vector3 GetParticleExternalForceAt(this ObiActor actor, int particleIndex)
		{
			return default(Vector3);
		}

		public static void SetParticleExternalForceAt(this ObiActor actor, int particleIndex, Vector3 force)
		{
		}

		public static Vector3 GetParticleExternalForceAtPercent(this ObiActor actor, float percent)
		{
			return default(Vector3);
		}

		public static void SetParticleExternalForceAtPercent(this ObiActor actor, float percent, Vector3 force)
		{
		}
	}
}
