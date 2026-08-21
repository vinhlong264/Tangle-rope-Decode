namespace PersistentSO
{
	public interface IPersistentVariable
	{
		Guid Guid { get; }

		string SaveKey => null;

		object InitialValueObject { get; }

		object ValueObject { get; }

		void Reset();
	}
}
