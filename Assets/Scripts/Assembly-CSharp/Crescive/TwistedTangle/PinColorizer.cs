using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class PinColorizer : MonoBehaviour
	{
		[SerializeField]
		private MeshRendererColorSetter colorSetter;

		[SerializeField]
		private Transform pinModelParent;

		[SerializeField]
		private PinConnection pinConnection;

		private RopeEntity rope;

		public Color Color => default(Color);

		public UnityEvent<Color> OnColorUpdated => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void UpdateRope()
		{
		}

		private void OnRopeColorChanged(Color color)
		{
		}

		public void SetColorSetter(MeshRendererColorSetter setter)
		{
		}

		public void SyncColorWithRope()
		{
		}

		public bool AnimateColor(Color c, float t)
		{
			return false;
		}

		public void SetColor(Color c)
		{
		}
	}
}
