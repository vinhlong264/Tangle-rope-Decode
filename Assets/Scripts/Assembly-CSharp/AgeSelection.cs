using UnityEngine;
using UnityEngine.UI;

public class AgeSelection : MonoBehaviour
{
	[SerializeField]
	private int answerCode;

	[SerializeField]
	private Button selectionButton;

	[SerializeField]
	private GameObject tickImage;

	public int AnswerCode => 0;

	public Button SelectionButton => null;

	public void SetTick(bool on)
	{
	}
}
