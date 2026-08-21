using Crescive.OneTimeDataSetter;

namespace Crescive.TwistedTangle
{
	public class VoidOneTimeSetterDelegate : BaseOneTimeSetterDelegate<object>
	{
		protected override object GetData()
		{
			return null;
		}
	}
}
