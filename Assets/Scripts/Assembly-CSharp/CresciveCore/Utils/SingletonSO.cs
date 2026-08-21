namespace CresciveCore.Utils
{
	public abstract class SingletonSO<T> : BaseSingletonSO where T : SingletonSO<T>
	{
		private static T _instance;

		public static T Instance => null;

		public sealed override void Initialize()
		{
		}

		public sealed override void Dispose()
		{
		}

		protected abstract void OnInitialize();

		protected abstract void OnDispose();
	}
}
