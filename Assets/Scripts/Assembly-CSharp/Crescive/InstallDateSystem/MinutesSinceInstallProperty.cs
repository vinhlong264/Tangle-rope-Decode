using Crescive.Scriptables;
using PersistentSO;
using UnityEngine;

namespace Crescive.InstallDateSystem
{
	[CreateAssetMenu(menuName = "Crescive/Install Date System/MinutesSinceInstallProperty")]
	public class MinutesSinceInstallProperty : IntScriptableProperty
	{
		[SerializeField]
		private PersistentStringVariable installDateVariable;

		protected override int GetValue()
		{
			return 0;
		}
	}
}
