using System.Collections.Generic;

namespace Crescive.DataService
{
	public interface IDataWithJson
	{
		List<JsonField> JsonData { get; }
	}
}
