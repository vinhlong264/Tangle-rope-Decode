using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiLogger : MonoBehaviour
{
	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private Button expandButton;

	[SerializeField]
	private Button hideButton;

	[SerializeField]
	private Button clearButton;

	[SerializeField]
	private RectTransform content;

	[SerializeField]
	private TMP_Text logText;

	private bool _isExpanded;

	private RectTransform _contentRectTransform;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void Log(string message)
	{
	}

	private void SetState(bool isExpanded)
	{
	}

	private void ClearLogs()
	{
	}

	private void ChangeStretch(float scaleFactor)
	{
	}
}
