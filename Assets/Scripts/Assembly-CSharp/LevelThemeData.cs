using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LevelThemeData
{
	public LevelTheme levelTheme;

	public GameObject wallPrefab;

	public GameObject groundPrefab;

	public GameObject upperWallPrefab;

	public GameObject lowerWallPrefab;

	public List<GameObject> lowerZoneProps;
}
