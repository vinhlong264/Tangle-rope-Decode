public abstract class DirectStoreModifyTargetWithData<T> : DirectStoreModifyTarget
{
	public void TryModify(T arg)
	{
	}

	protected abstract void ApplyModification(T arg);
}
