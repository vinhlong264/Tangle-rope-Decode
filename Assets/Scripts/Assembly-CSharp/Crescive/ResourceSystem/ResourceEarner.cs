using Crescive.HelperTypes;
using Crescive.Leveling;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.ResourceSystem
{
	public class ResourceEarner : MonoBehaviour
	{
		private enum FloatVariableType
		{
			LevelingFloat = 0,
			PersistentFloat = 1,
			AtomFloat = 2,
			AtomInt = 3,
			FloatVariableReference = 4,
			IntVariableReference = 5
		}

		[Header("References")]
		[SerializeField]
		private ResourceChannel resourceChannel;

		[SerializeField]
		private Transform earnTransform;

		[SerializeField]
		[Header("Income")]
		private FloatVariableType variableType;

		[SerializeField]
		private LevelingFloat amountLevelingFloat;

		[SerializeField]
		private PersistentFloatVariable amountPersistentFloat;

		[SerializeField]
		private FloatReference amountAtomFloat;

		[SerializeField]
		private IntReference amountAtomInt;

		[SerializeField]
		private FloatVariableReference amountFloatVariableReference;

		[SerializeField]
		private IntVariableReference amountIntVariableReference;

		[SerializeField]
		private bool roundIncome;

		[SerializeField]
		private bool hasFlatModifier;

		[SerializeField]
		private FloatReference amountFlatModifier;

		[SerializeField]
		private bool hasMultiplierModifier;

		[SerializeField]
		private FloatReference amountMultiplierModifier;

		[SerializeField]
		private bool hasPercentModifier;

		[SerializeField]
		private FloatReference amountPercentModifier;

		[SerializeField]
		private string info;

		[Header("Events")]
		public UnityEvent<float> OnResourceEarned;

		private float Amount => 0f;

		private float GetAmount()
		{
			return 0f;
		}

		public void EarnResource()
		{
		}

		public void EarnResourceCanvasPosition()
		{
		}

		public void EarnResourceCanvasPosition(Vector3 pos)
		{
		}

		public void EarnResourceCanvasPosition(float amount, Vector3 pos)
		{
		}
	}
}
