using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Command
{
	[CreateAssetMenu(fileName = "CommandChannel", menuName = "Crescive/Command/CommandChannel")]
	public class CommandChannel : ScriptableObject
	{
		[SerializeField]
		private int bufferSize;

		private List<ICommand> commands;

		private int index;

		public UnityEvent OnAddCommand;

		public UnityEvent OnUndoCommand;

		public UnityEvent OnRedoCommand;

		public UnityEvent<bool> OnCanUndoStateChanged;

		public UnityEvent<bool> OnCanRedoStateChanged;

		public bool HasCommands => false;

		public bool CanUndo => false;

		public bool CanRedo => false;

		public bool IsBufferFull => false;

		private void AddedCommand()
		{
		}

		private void UndoedCommand()
		{
		}

		private void RedoedCommand()
		{
		}

		private void TriggerStateChangeEvents()
		{
		}

		public void AddCommand(ICommand command)
		{
		}

		public void UndoCommand()
		{
		}

		public void RedoCommand()
		{
		}

		public void Reset()
		{
		}
	}
}
