using Crescive.Factory;
using UnityEngine;

public class TextPopupGenerator : MonoBehaviour
{
	[Header("References")]
	[SerializeField]
	private GameObjectFactory textPopupFactory;

	[SerializeField]
	private Transform spawnPoint;

	[Header("Settings")]
	[SerializeField]
	private string prefix;

	[SerializeField]
	private string suffix;

	public void CreatePopup(string text)
	{
	}

	public void CreatePopupInt(int value)
	{
	}
}
