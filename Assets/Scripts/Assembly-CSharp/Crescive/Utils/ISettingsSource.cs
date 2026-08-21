namespace Crescive.Utils
{
	public interface ISettingsSource<out T>
	{
		T Value { get; }
	}
}
