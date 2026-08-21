using UnityEngine;

namespace Crescive.Command
{
	public class CommandController : MonoBehaviour
	{
		[SerializeField]
		private CommandChannel channel;

		private void OnEnable()
		{
		}

		private void OnDisable()
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
	}
}
