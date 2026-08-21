using Crescive.Navigation;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class ColorLevelTutorialPopup : MonoBehaviour
{
	public Navigatable navigatable;

	public GameObject Step1;

	public GameObject Step2;

	public GameObject Step3;

	public StringVariable LevelType;

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

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnLevelCreated()
	{
	}

	public void OpenTutorial()
	{
	}

	public void CloseStep1()
	{
	}

	public void CloseStep2()
	{
	}

	public void CloseStep3()
	{
	}

	public void Close()
	{
	}
}
