using Crescive.Scriptables;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.ForceUpdater
{
	[CreateAssetMenu(fileName = "Update Available Scriptable Property", menuName = "Crescive/Force Updater/Update Available Scriptable Property")]
	public class UpdateAvailableScriptableProperty : BoolScriptableProperty
	{
		[SerializeField]
		private StringReference latestVersion;

		protected override bool GetValue()
		{
			return false;
		}
	}
}
