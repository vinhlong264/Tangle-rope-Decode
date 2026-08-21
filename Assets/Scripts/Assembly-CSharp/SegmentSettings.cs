using System;
using System.Collections.Generic;

[Serializable]
public class SegmentSettings : ICloneable
{
	public string Id;

	public bool isActive;

	public int showLevelLimit;

	public int buyLimit;

	public List<SegmentProduct> segmentProducts;

	public long startDateTimestamp;

	public long endDateTimestamp;

	public List<string> eventSkins;

	public long GetStartDate()
	{
		return 0L;
	}

	public long GetEndDate()
	{
		return 0L;
	}

	public virtual bool ValidateConfig(object obj)
	{
		return false;
	}

	public virtual bool ValidateObject(object obj)
	{
		return false;
	}

	public virtual bool IsValid(object obj)
	{
		return false;
	}

	public SegmentSettings(SegmentSettings? other)
	{
	}

	public object Clone()
	{
		return null;
	}

	public override bool Equals(object? obj)
	{
		return false;
	}

	protected bool Equals(SegmentSettings? other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
