using System.Collections.Generic;
using Crescive.HelperTypes;
using Crescive.SelectableItems;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Levels
{
	public class LevelDifficultyCreatorSync : MonoBehaviour
	{
		[SerializeField]
		private StringVariable difficultyDetailed;

		[SerializeField]
		private SelectableItemsController selectableItemsController;

		[SerializeField]
		private LevelDifficultySetterAction difficultySetterAction;

		[SerializeField]
		private List<StringVariableReference> difficulties;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void SyncSelection()
		{
		}

		private void OnSelectedItemIndexChanged(int index)
		{
		}
	}
}
