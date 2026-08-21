using System;
using UnityEngine;

namespace UnityAtoms
{
	[Serializable]
	public struct TransformPair : IPair<Transform>
	{
		[SerializeField]
		private Transform _item1;

		[SerializeField]
		private Transform _item2;

		public Transform Item1
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform Item2
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Deconstruct(out Transform item1, out Transform item2)
		{
			item1 = null;
			item2 = null;
		}
	}
}
