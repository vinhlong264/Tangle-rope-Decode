using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class RopeColorizer : MonoBehaviour
	{
		[SerializeField]
		private MeshRendererColorSetter colorSetter;

		[SerializeField]
		private RopeConnection ropeConnection;

		private bool hasPreviousColor;

		private PinEntity pin;

		public UnityEvent<Color> OnColorUpdated => null;

		public UnityEvent<Color> OnColorUpdatedTemporary => null;

		public UnityEvent<Color, int> OnSubColorUpdated => null;

		public Color PreviousColor { get; private set; }

		public Color Color => default(Color);

		public MeshRendererColorSetter ColorSetter => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void UpdatePin(PinEntity ropePin)
		{
		}

		private void OnPinColorChanged(Color color)
		{
		}

		private void SyncColorWithPin()
		{
		}

		private void UpdateMaterialColors(Color color)
		{
		}

		public void UpdateColor(Color color)
		{
		}

		public void UpdateColorTemporary(Color color)
		{
		}

		public void ReapplyColor()
		{
		}

		public void UpdateToWhiteColor()
		{
		}

		public void RestorePreviousColor()
		{
		}

		public void UpdateMaterialSubColor(Color color, int nameId)
		{
		}
	}
}
