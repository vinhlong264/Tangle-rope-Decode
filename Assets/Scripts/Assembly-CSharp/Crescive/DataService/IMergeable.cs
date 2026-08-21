namespace Crescive.DataService
{
	public interface IMergeable<in T> where T : IMergeable<T>
	{
		void Merge(T other);

		bool CanMergeWith(T other);
	}
}
