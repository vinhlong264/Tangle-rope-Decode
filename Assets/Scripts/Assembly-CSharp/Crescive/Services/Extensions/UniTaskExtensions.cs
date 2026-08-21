using Cysharp.Threading.Tasks;
using RSG;

namespace Crescive.Services.Extensions
{
	public static class UniTaskExtensions
	{
		public static RSG.IPromise<T> ToPromise<T>(this UniTask<T> uniTask)
		{
			return null;
		}
	}
}
