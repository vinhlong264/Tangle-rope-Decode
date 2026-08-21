using Crescive.Channels;
using UnityEngine;

namespace Crescive.TransformUtils
{
	[CreateAssetMenu(fileName = "Transform Channel", menuName = "Crescive/Scriptables/Channels/Transform Channel")]
	public class TransformChannel : ObjectChannel<Transform>
	{
		public void SetChild(Transform child)
		{
		}
	}
}
