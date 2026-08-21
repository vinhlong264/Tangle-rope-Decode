using Systems.ColorGameMode;
using Crescive.TCP2Utils;
using Crescive.Utils;
using Obi;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class RopeEntity : MonoBehaviour
	{
		[field: SerializeField]
		public ObiRope Rope { get; private set; }

		[field: SerializeField]
		public ObiRopeCursor RopeCursor { get; private set; }

		[field: SerializeField]
		public RopeColorizer RopeColorizer { get; private set; }

		[field: SerializeField]
		public RopeConnection RopeConnection { get; private set; }

		[field: SerializeField]
		public RopePinsMerger RopePinsMerger { get; private set; }

		[field: SerializeField]
		public TriggerChecker TriggerChecker { get; private set; }

		[field: SerializeField]
		public RopeCollider RopeCollider { get; private set; }

		[field: SerializeField]
		public RopeTension RopeTension { get; private set; }

		[field: SerializeField]
		public RopePinsSetup RopePinsSetup { get; private set; }

		[field: SerializeField]
		public RopeCutter RopeCutter { get; private set; }

		[field: SerializeField]
		public RopeOutlineWidthHighlighter Highlighter { get; private set; }

		[field: SerializeField]
		public RopePhysicToggler RopePhysicToggler { get; private set; }

		[field: SerializeField]
		public GoldenObjectVisualizer GoldenObjectVisualizer { get; private set; }

		[field: SerializeField]
		public RopeWidthScaler RopeWidthScaler { get; private set; }

		[field: SerializeField]
		public MeshRenderer RopeMeshRenderer { get; private set; }

		[field: SerializeField]
		public ObiRopeExtrudedRenderer ExtrudedRenderer { get; private set; }

		[field: SerializeField]
		public ObiRopeChainRenderer ChainRenderer { get; private set; }

		[field: SerializeField]
		public RopeColorController RopeColorController { get; private set; }

		public bool DisableRope { get; set; }
	}
}
