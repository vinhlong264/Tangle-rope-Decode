using System.Collections.Generic;
using UnityEngine;

public class GroundSkinController : MonoBehaviour
{
	[SerializeField]
	private Transform propsParent;

	[SerializeField]
	private List<LevelThemeData> levelThemesData;

	private List<Transform> walls;

	private GameObject _groundTheme;

	public void UpdateLayout(int columns, int rows, Vector2 spacing)
	{
	}

	private void GenerateProps(int columns, int rows, Vector2 spacing, LevelTheme levelTheme)
	{
	}

	private void ClearScene()
	{
	}
}
