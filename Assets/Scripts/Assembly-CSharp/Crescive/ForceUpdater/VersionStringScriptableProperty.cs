using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.ForceUpdater
{
	[CreateAssetMenu(fileName = "Version String Scriptable Property", menuName = "Crescive/Force Updater/Version String Scriptable Property")]
	public class VersionStringScriptableProperty : StringScriptableProperty
	{
		protected override string GetValue()
		{
			return null;
		}
	}
}
