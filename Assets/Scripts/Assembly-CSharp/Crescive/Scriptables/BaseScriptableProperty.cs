using UnityEngine;

namespace Crescive.Scriptables
{
	public abstract class BaseScriptableProperty : ScriptableObject
	{
		public abstract object ValueObject { get; }
	}
}
