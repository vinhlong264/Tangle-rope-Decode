using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardRecord : MonoBehaviour
{
	[SerializeField]
	[Header("References")]
	private TextMeshProUGUI nameText;

	[SerializeField]
	private TextMeshProUGUI rankText;

	[SerializeField]
	private Image flagImage;

	public RectTransform RectTransform => null;

	public int Rank { get; private set; }

	public void SetRank(int rank)
	{
	}

	public void SetNameAndFlag(string personName, Sprite flag)
	{
	}
}
