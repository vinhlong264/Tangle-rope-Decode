using System.Collections.Generic;
using Crescive.Channels;
using Obi;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	[CreateAssetMenu(fileName = "RopesChannel", menuName = "GameData/Map/Channels/Ropes Channel")]
	public class RopesChannel : ObjectsChannel<RopeEntity>
	{
		[SerializeField]
		private ObiCollisionsChannel collisionsChannel;

		[SerializeField]
		private float ropesIntersectRadius;

		[SerializeField]
		private float minYDiffToCheckIntersection;

		public UnityEvent<RopeEntity> OnRopeClicked;

		public UnityEvent OnAllRopePhysicsActivated;

		public UnityEvent OnAllRopePhysicsDeactivated;

		public List<RopeEntity> GoldenRopes => null;

		public List<RopeEntity> NotGoldenRopes => null;

		public bool HasAnyRopePhysicActive => false;

		public bool IsAllRopePhysicsActive => false;

		public bool IsAllRopePhysicsDeactivate => false;

		public int RopesCount => 0;

		public bool IsPreview { get; set; }

		private List<RopeEntity> SelectRopesFromActors(List<ObiActor> actors)
		{
			return null;
		}

		private List<ObiActor> GetContactingActorsFromRopes(List<RopeEntity> ropes, bool includeSelf, bool recursive = false, bool includeIgnoredContacts = false)
		{
			return null;
		}

		public bool IsAnyRopeReachedMaxTension(float maxPercent)
		{
			return false;
		}

		public float GetMaxTensionPercentage(bool includeMergingRopes = false)
		{
			return 0f;
		}

		public bool IsRopeReachedMaxTension(RopeEntity rope, float maxPercent)
		{
			return false;
		}

		public RopeEntity GetMaxTensionRope(bool includeMergingRopes = false)
		{
			return null;
		}

		public bool IsAnyRopeReachedMaxTensionColliding(RopeEntity rope, float maxPercent)
		{
			return false;
		}

		public void SetRopesPhysicsActive(IEnumerable<RopeEntity> ropes, bool active)
		{
		}

		public void SetRopesPhysicsActive(bool active)
		{
		}

		public void ActivateRopesPhysics()
		{
		}

		public void DeactivateRopesPhysics()
		{
		}

		public void ActivateCollidingRopesPhysicsRecursive(RopeEntity ropeEntity)
		{
		}

		public List<RopeEntity> GetCollidingRopes(RopeEntity rope, bool includeSelf = false, bool recursive = false, bool includeIgnoredContacts = false)
		{
			return null;
		}

		public List<List<RopeEntity>> GetContactGroups()
		{
			return null;
		}

		public void TriggerRopeClicked(RopeEntity ropeEntity)
		{
		}

		public bool IsAnyRopeMerging()
		{
			return false;
		}

		public bool AreAllRopesMergeStarted()
		{
			return false;
		}

		public List<ConnectedRope> GetConnectedRopes()
		{
			return null;
		}

		public List<ConnectedRopesGroup> GetConnectedRopesGroups()
		{
			return null;
		}

		public int GetConnectedRopesCount()
		{
			return 0;
		}

		public bool AreRopesHasIntersectionInPoint(RopeEntity rope1, RopeEntity rope2)
		{
			return false;
		}

		public bool IsRopeIntersectingWithAnyRope(RopeEntity rope)
		{
			return false;
		}

		public bool IsConnectedRopeInstersectingWithAnyRope(RopeEntity ropeEntity)
		{
			return false;
		}

		public void HighlightRopes()
		{
		}

		public void UnhighlightRopes()
		{
		}

		public void ToggleRopesHighlight(bool active)
		{
		}

		public void ToggleRopesHighlightExcludedRopes(bool active, params RopeEntity[] excludedRopes)
		{
		}

		public List<RopeEntity> GetValidRopes()
		{
			return null;
		}

		public bool AreRopesValid(List<RopeEntity> ropes)
		{
			return false;
		}

		public bool IsRopeValid(RopeEntity rope)
		{
			return false;
		}

		public bool IsPinValid(PinEntity pin)
		{
			return false;
		}

		public bool IsKeyValid(KeyEntity key)
		{
			return false;
		}
	}
}
