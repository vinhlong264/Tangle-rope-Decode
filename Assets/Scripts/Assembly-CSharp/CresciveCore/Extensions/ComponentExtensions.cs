using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CresciveCore.Extensions
{
	public static class ComponentExtensions
	{
		public static T GetOrAddComponent<T>(this Component c) where T : Component
		{
			return null;
		}

		public static List<T> GetComponentsInDirectChildren<T>(this Component c) where T : Component
		{
			return null;
		}

		public static Renderer GetRenderer(this Component c)
		{
			return null;
		}

		public static MeshRenderer GetMeshRenderer(this Component c)
		{
			return null;
		}

		public static Rigidbody GetRigidbody(this Component c)
		{
			return null;
		}

		public static Rigidbody GetOrAddRigidbody(this Component c)
		{
			return null;
		}

		public static Material GetMaterial(this Component c)
		{
			return null;
		}

		public static Collider GetCollider(this Component c)
		{
			return null;
		}

		public static MeshCollider GetMeshCollider(this Component c)
		{
			return null;
		}

		public static MeshCollider GetOrAddMeshCollider(this Component c)
		{
			return null;
		}

		public static MeshFilter GetMeshFilter(this Component c)
		{
			return null;
		}

		public static Mesh GetMesh(this Component c)
		{
			return null;
		}

		public static void SetMesh(this Component c, Mesh mesh)
		{
		}

		public static Vector3 GetPosition(this Component c)
		{
			return default(Vector3);
		}

		public static void SetPosition(this Component c, Vector3 position)
		{
		}

		public static Quaternion GetRotation(this Component c)
		{
			return default(Quaternion);
		}

		public static void SetRotation(this Component c, Quaternion rotation)
		{
		}

		public static Vector3 GetLocalScale(this Component c)
		{
			return default(Vector3);
		}

		public static void SetLocalScale(this Component c, Vector3 localScale)
		{
		}

		public static Vector3 GetLossyScale(this Component c)
		{
			return default(Vector3);
		}

		public static void SetLayerRecursively(this Component c, int layer)
		{
		}

		public static RectTransform GetRectTransform(this Component c)
		{
			return null;
		}

		public static Dictionary<Graphic, Color> SetGraphicsDarker(this Component c, float darkness)
		{
			return null;
		}
	}
}
