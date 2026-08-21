using System.Collections.Generic;
using Obi;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Crescive.TwistedTangle
{
	public class RopeConnection : MonoBehaviour
	{
		[SerializeField]
		[Header("References")]
		private RopeEntity ropeEntity;

		[SerializeField]
		private ObiCollisionsChannel collisionsChannel;

		[SerializeField]
		private ObiParticleAttachment startAttachment;

		[SerializeField]
		private ObiParticleAttachment endAttachment;

		[FormerlySerializedAs("pinEnterParticlesOffset")]
		[SerializeField]
		[Range(0f, 0.5f)]
		private float pinEnterParticlesOffsetPercent;

		[SerializeField]
		private int normalCollisionFilterCategory;

		[SerializeField]
		private int sharedCollisionFilterCategory;

		private ConnectedRope connectedRope;

		private bool isConnectedRopeInitialized;

		public UnityEvent OnConnectionUpdated;

		public UnityEvent<PinEntity> OnConnectionAdded;

		public UnityEvent<PinEntity> OnConnectionRemoved;

		public PinEntity StartPin { get; private set; }

		public PinEntity EndPin { get; private set; }

		public RopeEntity RopeEntity => null;

		public List<PinEntity> Pins => null;

		public int PinsCount => 0;

		public bool HasAnyConnectedPin => false;

		public bool AllPinsConnected => false;

		public bool HasPinWithMultipleRopes => false;

		public bool HasPinWithSingleRope => false;

		public PinEntity PinWithSingleRope => null;

		public List<PinEntity> PinsWithSingleRope => null;

		public List<PinEntity> PinsWithMultipleRopes => null;

		public List<RopeEntity> OtherConnectedRopes => null;

		public bool HasOtherConnectedRopes => false;

		public PinEntity PinWithMultipleRopes => null;

		private List<PinEntity> GetPins()
		{
			return null;
		}

		private void GetAllConnectedRopesRecursive(RopeEntity rope, List<RopeEntity> ropes)
		{
		}

		private void ConnectionUpdated()
		{
		}

		private void UpdateConnectedRopeData(bool force = false)
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void UpdateStartPinParticlesCollisionFilter(int mask)
		{
		}

		private void UpdateEndPinParticlesCollisionFilter(int mask)
		{
		}

		private int GetCollisionFilterMask(bool isShared)
		{
			return 0;
		}

		public PinEntity GetOtherPin(PinEntity pinEntity)
		{
			return null;
		}

		public void ConnectStartPin(PinEntity pinEntity)
		{
		}

		public void ConnectEndPin(PinEntity pinEntity)
		{
		}

		public void DisconnectStartPin()
		{
		}

		public void DisconnectEndPin()
		{
		}

		public void DisconnectPin(PinEntity pinEntity)
		{
		}

		public void DisconnectPinWithCut(PinEntity pinEntity)
		{
		}

		public void DisconnectPins(List<PinEntity> pins)
		{
		}

		public void DisconnectAllPins()
		{
		}

		public List<RopeEntity> GetConnectedRopesRecursive(bool includeSelf = false)
		{
			return null;
		}

		public List<RopeEntity> GetConnectedRopes(bool includeSelf = false)
		{
			return null;
		}

		public List<PinEntity> GetConnectedRopesPins(bool includeSelf = false)
		{
			return null;
		}

		public bool IsConnectedRopeColliding()
		{
			return false;
		}

		public RopeEntity GetConnectedRopeFrom(List<RopeEntity> ropes)
		{
			return null;
		}

		public void UpdateCollisionFilterByPin(PinEntity pinEntity, bool isShared)
		{
		}

		public List<int> GetStartPinParticlesSolverIndices()
		{
			return null;
		}

		public List<int> GetEndPinParticlesSolverIndices()
		{
			return null;
		}

		public ConnectedRope GetConnectedRopeData()
		{
			return null;
		}

		public int GetClosestParticleIndexToPin(PinEntity pinEntity)
		{
			return 0;
		}

		public bool IsPinConnectedToStart(PinEntity pinEntity)
		{
			return false;
		}

		public bool IsPinConnectedToEnd(PinEntity pinEntity)
		{
			return false;
		}

		public bool IsPinConnected(PinEntity pinEntity)
		{
			return false;
		}

		public bool ArePinsConnected(PinEntity pin1, PinEntity pin2)
		{
			return false;
		}

		public float GetConnectedParticlePercent(PinEntity pinEntity)
		{
			return 0f;
		}

		public int GetConnectedParticleIndex(PinEntity pinEntity)
		{
			return 0;
		}
	}
}
