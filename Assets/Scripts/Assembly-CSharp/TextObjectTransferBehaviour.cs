using System;
using Crescive.Text;
using Crescive.TransformUtils;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TextObjectTransferBehaviour : MonoBehaviour
{
	[SerializeField]
	private ObjectTransferControllerChannel objectTransferControllerChannel;

	[SerializeField]
	private ObjectTransferer objectTransferer;

	[SerializeField]
	private TransformChannel destination;

	[SerializeField]
	private TMP_Text tmpPrefab;

	[SerializeField]
	private bool isCanvasPosition;

	[SerializeField]
	private TransformChannel defaultStartTransform;

	[SerializeField]
	private string prefix;

	[SerializeField]
	private string suffix;

	[SerializeField]
	private FloatTextFormatter floatFormatter;

	[Space]
	public UnityEvent<int> OnTransferredInt;

	public UnityEvent<float> OnTransferredFloat;

	public UnityEvent<string> OnTransferredString;

	private void Transfer(string text, Transform start, Action transferredCallback)
	{
	}

	public void TransferInt(int value)
	{
	}

	public void TransferFloat(float value)
	{
	}

	public void TransferString(string value)
	{
	}

	public void TransferIntWithStart(int value, Transform start)
	{
	}

	public void TransferFloatWithStart(float value, Transform start)
	{
	}

	public void TransferStringWithStart(string value, Transform start)
	{
	}
}
