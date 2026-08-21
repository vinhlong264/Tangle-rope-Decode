using Crescive.Scriptables;
using UnityEngine;

namespace CresciveCore
{
	[CreateAssetMenu(menuName = "Crescive/LevelSystem/Level Number Scriptable Property")]
	public class LevelNumberScriptableProperty : IntScriptableProperty
	{
		[SerializeField]
		private LevelSystem levelSystem;

		protected override int GetValue()
		{
			return 0;
		}
	}
}
