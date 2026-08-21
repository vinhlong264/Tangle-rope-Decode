using Crescive.Draggables;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class ColumnEntity : MonoBehaviour
	{
		[field: SerializeField]
		public Draggable Draggable { get; private set; }
	}
}
