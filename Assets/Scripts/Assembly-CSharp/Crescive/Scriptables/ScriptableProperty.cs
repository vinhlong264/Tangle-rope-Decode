namespace Crescive.Scriptables
{
	public abstract class ScriptableProperty<T> : BaseScriptableProperty
	{
		public T Value => default(T);

		public override object ValueObject => null;

		protected abstract T GetValue();
	}
}
