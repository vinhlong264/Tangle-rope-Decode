using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Text
{
	public class Text3DChar : MonoBehaviour
	{
		private enum Text3DCharRendererType
		{
			Mesh = 0,
			SkinnedMesh = 1
		}

		[Header("References")]
		[SerializeField]
		private Text3DCharRendererType rendererType;

		[SerializeField]
		private MeshFilter meshFilter;

		[SerializeField]
		private MeshRenderer meshRenderer;

		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Header("Settings")]
		[SerializeField]
		private List<string> characters;

		[SerializeField]
		private bool ignoreMaterial;

		private Renderer Renderer => null;

		private Mesh Mesh => null;

		public List<string> Characters => null;

		public float Width => 0f;

		public float Offset => 0f;

		public void UpdateChar(Vector3 position, Vector3 scale, Material material)
		{
		}
	}
}
