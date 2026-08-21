using System.Collections.Generic;
using PersistentSO;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class PresetColorsHandler : MonoBehaviour
	{
		[SerializeField]
		private PersistentColorList persistentColorList;

		[SerializeField]
		private GameObject colorButton;

		[SerializeField]
		private Transform colorButtonParent;

		private int createdButtonCount;

		private List<PresetColorButtonHandler> buttonHandlers;

		private void Start()
		{
		}

		private void InitializeColorButtons()
		{
		}

		private void CreateColorButton(Color colorToCreate)
		{
		}

		public void SaveColor(Color colorToSave)
		{
		}

		public void RemoveButtonFromList(int indexToRemove)
		{
		}
	}
}
