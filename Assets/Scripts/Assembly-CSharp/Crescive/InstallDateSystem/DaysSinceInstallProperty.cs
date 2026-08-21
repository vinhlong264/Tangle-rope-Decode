using Crescive.Scriptables;
using PersistentSO;
using UnityEngine;

namespace Crescive.InstallDateSystem
{
	[CreateAssetMenu(menuName = "Crescive/Install Date System/DaysSinceInstallProperty")]
	public class DaysSinceInstallProperty : IntScriptableProperty
	{
		[SerializeField]
		private PersistentStringVariable installDateVariable;

		protected override int GetValue()
		{
			return 0;
		}
	}
}
