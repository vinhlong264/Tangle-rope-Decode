using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Layout
{
	public class SimpleScrollSnapPage : MonoBehaviour
	{
		[SerializeField]
		private StringReference key;

		[Space]
		[SerializeField]
		private int index;

		public string Key => null;

		public int Index => 0;

		public void SetIndex(int newIndex)
		{
		}
	}
}
