using System.Collections.Generic;
using Spine.Unity;
using UnityEngine;

namespace Plinko
{
	public class Spawner : MonoBehaviour
	{
		[SerializeField]
		internal SpawnPoint[] spawnPoints;

		[SerializeField]
		private Ball ballPrefab;

		[SerializeField]
		private ForceMode2D forceMode;

		[SerializeField]
		private SkeletonAnimation skeletonAnimation1;

		[SerializeField]
		private SkeletonAnimation skeletonAnimation2;

		[SerializeField]
		private BallCountArea ballCountArea;

		[SerializeField]
		private string idleAnimation;

		[SerializeField]
		private string actionAnimation;

		private PlinkoController plinkoController;

		private List<Ball> balls;

		private void Awake()
		{
		}

		internal void Initialize(PlinkoController plinkoController)
		{
		}

		public void OnSpawnPointTriggered(SpawnPoint spawnPoint, bool isSimulation)
		{
		}

		public bool IsAnyBallActive()
		{
			return false;
		}

		private Ball GetBall()
		{
			return null;
		}

		internal void SetBallGravityScale(float ballGravityScale)
		{
		}

		private void PlayActionThenIdle()
		{
		}
	}
}
