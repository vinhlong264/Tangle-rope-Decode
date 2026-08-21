using System;
using System.Collections.Generic;

[Serializable]
public class LevelsSettings : ICloneable
{
	public List<int> levelsOrder;

	public List<LevelWithTime> levelsData;

	public List<int> loopLevelsOrder;

	public List<LevelWithTime> loopLevelsWithTimes;

	public List<FillerLevelData> fillerLevels;

	public List<LevelOverrideData> overrideLevel;

	public List<string> levelDifficultPatterns;

	private LevelsSettings(LevelsSettings levelsSettings)
	{
	}

	public object Clone()
	{
		return null;
	}
}
