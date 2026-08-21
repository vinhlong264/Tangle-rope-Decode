using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Command
{
	public class CommandChannelListener : MonoBehaviour
	{
		[SerializeField]
		private CommandChannel commandChannel;

		public UnityEvent OnAddCommand;

		public UnityEvent OnUndoCommand;

		public UnityEvent OnRedoCommand;

		public UnityEvent<bool> OnCanUndoStateChanged;

		public UnityEvent<bool> OnCanRedoStateChanged;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
