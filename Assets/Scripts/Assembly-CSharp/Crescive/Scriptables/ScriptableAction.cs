using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Scriptables
{
	[CreateAssetMenu(fileName = "Scriptable Action", menuName = "Crescive/Scriptables/Action/Scriptable Action")]
	public class ScriptableAction : ScriptableObject
	{
		[SerializeField]
		private UnityEvent action;

		public void Invoke()
		{
		}
	}
	public abstract class ScriptableAction<T> : ScriptableObject
	{
		[SerializeField]
		private UnityEvent<T> action;

		public void Invoke(T args)
		{
		}
	}
}
