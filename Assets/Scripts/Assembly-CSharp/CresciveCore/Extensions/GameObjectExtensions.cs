using System.Collections.Generic;
using UnityEngine;

namespace CresciveCore.Extensions
{
	public static class GameObjectExtensions
	{
		public static T GetOrAddComponent<T>(this GameObject go) where T : Component
		{
			return null;
		}

		public static List<T> GetComponentsInDirectChildren<T>(this GameObject go) where T : Component
		{
			return null;
		}

		public static Renderer GetRenderer(this GameObject go)
		{
			return null;
		}

		public static MeshRenderer GetMeshRenderer(this GameObject go)
		{
			return null;
		}

		public static Rigidbody GetRigidbody(this GameObject go)
		{
			return null;
		}

		public static Rigidbody GetOrAddRigidbody(this GameObject go)
		{
			return null;
		}

		public static Material GetMaterial(this GameObject go)
		{
			return null;
		}

		public static Collider GetCollider(this GameObject go)
		{
			return null;
		}

		public static MeshCollider GetMeshCollider(this GameObject go)
		{
			return null;
		}

		public static MeshCollider GetOrAddMeshCollider(this GameObject go)
		{
			return null;
		}

		public static MeshFilter GetMeshFilter(this GameObject go)
		{
			return null;
		}

		public static Mesh GetMesh(this GameObject go)
		{
			return null;
		}

		public static void SetMesh(this GameObject go, Mesh mesh)
		{
		}

		public static Vector3 GetPosition(this GameObject go)
		{
			return default(Vector3);
		}

		public static void SetPosition(this GameObject go, Vector3 position)
		{
		}

		public static Quaternion GetRotation(this GameObject go)
		{
			return default(Quaternion);
		}

		public static void SetRotation(this GameObject go, Quaternion rotation)
		{
		}

		public static Vector3 GetLocalScale(this GameObject go)
		{
			return default(Vector3);
		}

		public static void SetLocalScale(this GameObject go, Vector3 localScale)
		{
		}

		public static Vector3 GetLossyScale(this GameObject go)
		{
			return default(Vector3);
		}

		public static void SetLayerRecursively(this GameObject obj, int layer)
		{
		}

		public static void SetOverrideSortCanvas(this GameObject go, bool value, short sort)
		{
		}
	}
}
