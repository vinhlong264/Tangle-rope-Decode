using System;
using UnityEngine;

namespace Crescive.MultiplierData
{
	[Serializable]
	[CreateAssetMenu(fileName = "New Multipliers", menuName = "Crescive/GameData/Multiplier/MultiplierArgs")]
	public class MultiplierArgs : ScriptableObject
	{
		public MultiplierData Data;
	}
}
