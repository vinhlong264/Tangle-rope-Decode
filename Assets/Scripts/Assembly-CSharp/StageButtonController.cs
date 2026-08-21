using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StageButtonController : MonoBehaviour
{
	private Button _button;

	private Image _image;

	[SerializeField]
	private Button deleteButton;

	[SerializeField]
	private TMP_Text stageNameText;

	[SerializeField]
	private Sprite activeSprite;

	[SerializeField]
	private Sprite inactiveSprite;

	private int _index;

	private Action<int> _onClickAction;

	private Button Button => null;

	private Image Image => null;

	public void SetStageButton(int index, bool isActive, Action<int> onClick = null)
	{
	}

	public void SetDeleteButton(Action onClick = null, bool forceClose = false)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
