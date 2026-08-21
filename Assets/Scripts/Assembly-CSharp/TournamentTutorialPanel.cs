using Crescive.Navigation;
using UnityEngine;

public class TournamentTutorialPanel : MonoBehaviour
{
	[SerializeField]
	private Navigatable navigatable;

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

	public void OnShown()
	{
	}

	public void OnClicked()
	{
	}
}
