using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class SegmentedOfferSettings : ICloneable
{
	public List<SegmentSettings> SegmentSettings;

	private List<string> SegmentIds => null;

	public bool HasSegment(string id)
	{
		return false;
	}

	[SpecialName]
	private List<string> GetSegmentIds()
	{
		return null;
	}

	public object Clone()
	{
		return null;
	}

	public SegmentSettings FindSegmentById(string id)
	{
		return null;
	}

	public bool IsSegmentValid(string id)
	{
		return false;
	}

	public SegmentSettings GetAvailableSegment(string id)
	{
		return null;
	}

	public SegmentSettings GetSegment(string id)
	{
		return null;
	}

	public SegmentedOfferSettings()
	{
	}

	public SegmentedOfferSettings(SegmentedOfferSettings other)
	{
	}

	public SegmentedOfferSettings(List<SegmentSettings> segmentSettings)
	{
	}

	public List<SegmentSettings> GetAllActiveSegments()
	{
		return null;
	}
}
