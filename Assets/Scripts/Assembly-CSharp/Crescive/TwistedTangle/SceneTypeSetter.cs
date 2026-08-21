using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[DefaultExecutionOrder(-1000000000)]
	public class SceneTypeSetter : MonoBehaviour
	{
		[SerializeField]
		private StringVariable sceneTypeId;

		[SerializeField]
		private StringReference thisSceneTypeId;

		private void Awake()
		{
		}
	}
}
