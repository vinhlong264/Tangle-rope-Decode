using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Level
{
	[DefaultExecutionOrder(-10000)]
	public class LevelTypeSetup : MonoBehaviour
	{
		[SerializeField]
		private StringConstant levelType;

		[SerializeField]
		private StringVariable currentLevelToSetup;

		private void Awake()
		{
		}
	}
}
