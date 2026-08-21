using Crescive.Draggables;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class PinModelController : MonoBehaviour
	{
		[SerializeField]
		private MeshRendererColorSetter colorSetter;

		[SerializeField]
		private PinMergeDelegate modelPinMergeDelegate;

		[SerializeField]
		private DraggableDelegate modelDraggableDelegate;

		[SerializeField]
		private PinEntity pin;

		public void Initialize(PinEntity pinEntity)
		{
		}
	}
}
