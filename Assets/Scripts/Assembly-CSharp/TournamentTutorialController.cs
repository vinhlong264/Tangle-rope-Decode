using UnityEngine;

public class TournamentTutorialController : MonoBehaviour
{
	[SerializeField]
	private GameObject closeButton;

	[SerializeField]
	private GameObject tutorialHighlight;

	[SerializeField]
	private GameObject tutorialArrow;

	[SerializeField]
	private GameObject claimObject;

	public static bool IsTutorialShown
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void TryRun()
	{
	}

	public void StopIfAny()
	{
	}

	public void HideTutorial()
	{
	}

	public void CompleteTutorial()
	{
	}
}
