using System;
using UnityEngine;

namespace Crescive.ResourceSystem
{
	[Serializable]
	public class ResourceValueEventArgs
	{
		[field: SerializeField]
		public float Value { get; private set; }

		[field: SerializeField]
		public string Info { get; private set; }

		[field: SerializeField]
		public Vector3? Position { get; private set; }

		[field: SerializeField]
		public bool IsCanvasPosition { get; private set; }

		public ResourceValueEventArgs(float value, string info = "", Vector3? position = null, bool isCanvasPosition = false)
		{
		}
	}
}
