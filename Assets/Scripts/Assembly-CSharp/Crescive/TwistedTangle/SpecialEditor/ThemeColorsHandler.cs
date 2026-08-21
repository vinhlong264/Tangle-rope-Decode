using System.Collections.Generic;
using PersistentSO;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class ThemeColorsHandler : MonoBehaviour
	{
		[SerializeField]
		private PersistentColorListList persistentColorListList;

		[SerializeField]
		private GameObject colorButton;

		[SerializeField]
		private Transform colorButtonParent;

		private int createdButtonCount;

		private List<ThemeColorButtonHandler> buttonHandlers;

		private void Start()
		{
		}

		private void InitializeColorButtons()
		{
		}

		private void CreateColorButton(ColorListStruct colorToCreate)
		{
		}

		public void SaveColor(ColorListStruct colorToSave)
		{
		}

		public void RemoveButtonFromList(int indexToRemove)
		{
		}
	}
}
