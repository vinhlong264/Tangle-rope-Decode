using System.IO;

namespace PersistentSO
{
	public static class BinaryReaderExtensions
	{
		public static Guid ReadGuid(this BinaryReader reader)
		{
			return default(Guid);
		}
	}
}
