using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class PinConnection : MonoBehaviour
	{
		[SerializeField]
		private PinEntity pinEntity;

		[SerializeField]
		private List<RopeEntity> connectedRopes;

		[SerializeField]
		private Transform ropeConnectionPoint;

		public UnityEvent<RopeEntity> OnRopeConnected;

		public UnityEvent<RopeEntity> OnRopeDisconnected;

		public UnityEvent OnConnectionUpdated;

		public Transform RopeConnectionPoint => null;

		public Vector3 RopeConnectionOffset => default(Vector3);

		public List<RopeEntity> ConnectedRopes => null;

		public int ConnectedRopesCount => 0;

		public bool HasMultipleConnectedRopes => false;

		public bool HasSingleConnectedRope => false;

		public List<RopeEntity> MergingConnectedRopes => null;

		public List<RopeEntity> NotMergingConnectedRopes => null;

		public bool HasSingleNotMergingConnectedRope => false;

		public RopeEntity FirstConnectedRope => null;

		public bool HasConnectedRope => false;

		public bool HasConnectedPin => false;

		public PinEntity ConnectedPin => null;

		private void ConnectionUpdated()
		{
		}

		public void ConnectRope(RopeEntity ropeEntity)
		{
		}

		public void DisconnectRope(RopeEntity ropeEntity)
		{
		}

		public void DisconnectAllRopes()
		{
		}

		public void UpdateRopeCollisionFilters()
		{
		}
	}
}
