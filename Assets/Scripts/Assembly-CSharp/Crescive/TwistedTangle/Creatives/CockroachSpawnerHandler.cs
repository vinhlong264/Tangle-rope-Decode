using Crescive.Draggables;
using Crescive.Draggables.EventParams;
using UnityEngine;

namespace Crescive.TwistedTangle.Creatives
{
	public class CockroachSpawnerHandler : MonoBehaviour
	{
		[SerializeField]
		private GameObject cockroachSpawnerGameObject;

		[SerializeField]
		private DraggablesControllerChannel draggablesControllerChannel;

		[SerializeField]
		private GameObject roachCrusherGameObject;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void DraggableGrabbed(DraggableEventParams eventParams)
		{
		}

		private void DraggableDropped(DraggableDropEventParams eventParams)
		{
		}
	}
}
