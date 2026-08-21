using System;
using System.Threading;
using RSG;

namespace Crescive.Services.Extensions
{
	public static class IPromiseExtensions
	{
		public static IObservable<T> ToObservable<T>(this IPromise<T> promise, IDisposable cd = null)
		{
			return null;
		}

		public static IObservable<T> ToObservable<T>(this IPromise<T> promise, CancellationToken ct)
		{
			return null;
		}
	}
}
