using System;
using System.Collections;
using Proyecto26;
using UnityEngine;

namespace Crescive.Services
{
	public static class HttpRequester
	{
		public static IEnumerator Request(RequestHelper options, Action<RequestException, ResponseHelper> callback)
		{
			return null;
		}

		public static IObservable<ResponseHelper> RequestAsObservable(RequestHelper options, Action<RequestException, ResponseHelper> callback, MonoBehaviour behaviour)
		{
			return null;
		}
	}
}
