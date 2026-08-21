using Crescive.HelperTypes;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class MoveCountController : MonoBehaviour
	{
		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private FloatVariableReference outOfMovesDelay;

		private bool isOutOfMoves;

		private bool isCheckingOutOfMoves;

		private float outOfMovesTimer;

		public UnityEvent OnOutOfMoves;

		public UnityEvent OnMoveCountZero;

		[field: SerializeField]
		public IntReference CurrentMoveCount { get; private set; }

		[field: SerializeField]
		public BoolReference HasMoveCount { get; private set; }

		[field: SerializeField]
		public IntReference PerformedMoveCount { get; private set; }

		[field: SerializeField]
		public BoolReference IsMoveCountGreaterThanZero { get; private set; }

		private void Update()
		{
		}

		private void StartCheckingOutOfMoves()
		{
		}

		private void TryPerformingOutOfMove()
		{
		}

		private void CheckOutOfMoves()
		{
		}

		public void OnMoved()
		{
		}

		public void KillOutOfMovesCheck()
		{
		}

		public void IncreaseMoveCount(int amount)
		{
		}

		public void ResetOutOfMoves()
		{
		}

		public void ResetAllData()
		{
		}
	}
}
