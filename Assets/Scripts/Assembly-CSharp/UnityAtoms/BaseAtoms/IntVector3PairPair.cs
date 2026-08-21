using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[Serializable]
	public struct IntVector3PairPair : IPair<IntVector3Pair>
	{
		[SerializeField]
		private IntVector3Pair _item1;

		[SerializeField]
		private IntVector3Pair _item2;

		public IntVector3Pair Item1
		{
			get
			{
				return default(IntVector3Pair);
			}
			set
			{
			}
		}

		public IntVector3Pair Item2
		{
			get
			{
				return default(IntVector3Pair);
			}
			set
			{
			}
		}

		public void Deconstruct(out IntVector3Pair item1, out IntVector3Pair item2)
		{
			item1 = default(IntVector3Pair);
			item2 = default(IntVector3Pair);
		}
	}
}
