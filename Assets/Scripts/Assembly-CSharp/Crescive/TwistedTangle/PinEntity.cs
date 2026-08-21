using Crescive.Draggables;
using Crescive.Utils;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class PinEntity : MonoBehaviour
	{
		[field: SerializeField]
		public Draggable Draggable { get; private set; }

		[field: SerializeField]
		public PinConnection PinConnection { get; private set; }

		[field: SerializeField]
		public PinColorizer PinColorizer { get; private set; }

		[field: SerializeField]
		public Lock Locker { get; private set; }

		[field: SerializeField]
		public ObjectSelector Selector { get; private set; }

		[field: SerializeField]
		public GoldenObjectVisualizer GoldenObjectVisualizer { get; private set; }

		[field: SerializeField]
		public Collider Collider { get; private set; }

		[field: SerializeField]
		public PinMergeDelegate PinMergeDelegate { get; set; }
	}
}
